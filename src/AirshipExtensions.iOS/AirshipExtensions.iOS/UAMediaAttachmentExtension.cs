using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Foundation;
using UserNotifications;

namespace AirshipExtensions
{
	public class UAMediaAttachmentExtension : UNNotificationServiceExtension
	{
		Action<UNNotificationContent> ContentHandler { get; set; }
		UNMutableNotificationContent BestAttemptContent { get; set; }
		UNMutableNotificationContent ModifiedContent { get; set; }
		NSUrlSessionDownloadTask DownloadTask { get; set; }
		UAMediaAttachmentPayload AttachmentPayload { get; set; }

		protected UAMediaAttachmentExtension(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void DidReceiveNotificationRequest(UNNotificationRequest request, Action<UNNotificationContent> contentHandler)
		{
			AttachmentPayload = UAMediaAttachmentPayload.PayloadWithJSONObject(request.Content.UserInfo["com.urbanairship.media_attachment"]);
			if (AttachmentPayload == null)
			{
				contentHandler(request.Content);
				return;
			}

			ContentHandler = contentHandler;
			BestAttemptContent = (UNMutableNotificationContent)request.Content.MutableCopy();
			ModifiedContent = (UNMutableNotificationContent)request.Content.MutableCopy();

			DownloadTask = NSUrlSession.SharedSession.CreateDownloadTask(NSUrl.FromString(AttachmentPayload.Urls[0]), HandleResponse);
			DownloadTask.Resume();
		}

		public void HandleResponse(NSUrl location, NSUrlResponse response, NSError error)
		{
			if (error != null || location == null)
			{
				ContentHandler(BestAttemptContent);
				return;
			}

			NSUrl attachmentUrl = RenameTempFile(location, response.Url);

			List<string> knownExtensions = new List<string> { "jpg", "jpeg", "png", "gif", "aif", "aiff", "mp3", "mpg", "mpeg", "mp4", "m4a", "wav", "avi" };
			if (!knownExtensions.Contains(attachmentUrl.LastPathComponent.ToLower()))
			{
				AttachmentPayload.Options.TypeHint = InferType(attachmentUrl);
			}


			UNNotificationAttachment attachment = UNNotificationAttachment.FromIdentifier("", attachmentUrl, AttachmentPayload.Options, out error);
			if (error != null)
			{
				ContentHandler(BestAttemptContent);
				return;
			}

			if (AttachmentPayload.Content.Body != null)
			{
				ModifiedContent.Body = AttachmentPayload.Content.Body;
			}

			if (AttachmentPayload.Content.Title != null)
			{
				ModifiedContent.Title = AttachmentPayload.Content.Title;
			}

			if (AttachmentPayload.Content.Subtitle != null)
			{
				ModifiedContent.Subtitle = AttachmentPayload.Content.Subtitle;
			}

			ModifiedContent.Attachments = new UNNotificationAttachment[] { attachment };

			ContentHandler(ModifiedContent);
		}

		public override void TimeWillExpire()
		{
			if (DownloadTask != null)
			{
				DownloadTask.Cancel();
			}

			ContentHandler(BestAttemptContent);
		}

		private string InferType(NSUrl attachmentUrl)
		{
			// Offset 0
			Dictionary<string, List<byte[]>> headersOffset0 = new Dictionary<string, List<byte[]>>
			{
				{ "public.jpeg", new List<byte[]>() {
					new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 },
					new byte[] { 0xFF, 0xD8, 0xFF, 0xE2 },
					new byte[] { 0xFF, 0xD8, 0xFF, 0xE3 }
					}
				},

				{ "public.png", new List<byte[]>() {
					new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A }
					}
				},


				{ "com.compuserve.gif", new List<byte[]>() {
					new byte[] { 0x47, 0x49, 0x46, 0x38 }
					}
				},

				{ "public.aiff-audio", new List<byte[]>() {
					new byte[] { 0x41, 0x56, 0x49, 0x20 }
					}
				},

				{ "public.mp3", new List<byte[]>() {
					new byte[] { 0x49, 0x44, 0x33 }
					}
				},

				{ "public.mpeg", new List<byte[]>() {
					new byte[] { 0x00, 0x00, 0x01, 0xBA },
						new byte[] { 0x00, 0x00, 0x01, 0xB3 }
					}
				}
			};

			// Offset 4
			Dictionary<string, List<byte[]>> headersOffset4 = new Dictionary<string, List<byte[]>>
			{
				{ "public.mpeg-4", new List<byte[]>() {
						new byte[] { 0x66, 0x74, 0x79, 0x70, 0x6D, 0x70, 0x34, 0x31 },
						new byte[] { 0x66, 0x74, 0x79, 0x70, 0x6D, 0x70, 0x34, 0x32 }
					}
				},

				{ "public.mpeg-4-audio", new List<byte[]>() {
					new byte[] { 0x66, 0x74, 0x79, 0x70, 0x4D, 0x34, 0x41, 0x20 }
					}
				},

			};

			// Offset 8
			Dictionary<string, List<byte[]>> headersOffset8 = new Dictionary<string, List<byte[]>>
			{
				{ "com.microsoft.waveform-audio", new List<byte[]>() {
					new byte[] { 0x57, 0x41, 0x56, 0x45 }
					}
				},

				{ "public.avi", new List<byte[]>() {
					new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A }
					}
				},
			};


			byte[] header = new byte[16];
			using (BinaryReader reader = new BinaryReader(new FileStream(attachmentUrl.Path, FileMode.Open)))
			{
				reader.Read(header, 0, 16);
			}

			Dictionary<string, List<byte[]>>[] headerDictionaries = { headersOffset0, headersOffset4, headersOffset8 };

			for (int i = 0; i <= 8; i += 4)
			{
				foreach (var entry in headersOffset0)
				{
					foreach (byte[] signature in entry.Value)
					{
						byte[] segment = new byte[signature.Length];
						Array.Copy(header, i, segment, i, signature.Length);

						if (segment.SequenceEqual(signature))
						{
							return entry.Key;
						}
					}
				}
			}

			return null;
		}

		private NSUrl RenameTempFile(NSUrl tempFileUrl, NSUrl originalUrl)
		{
			string suffix = string.Format("-{0}", originalUrl.LastPathComponent);
			NSUrl destinationUrl = NSUrl.CreateFileUrl(new string[] { tempFileUrl.Path + suffix });

			NSError error = null;

			if (NSFileManager.DefaultManager.FileExists(destinationUrl.Path))
			{

				NSFileManager.DefaultManager.Remove(destinationUrl.Path, out error);
				if (error != null)
				{
					Console.WriteLine("Error removing file {0}: {1}", destinationUrl.Path, error.LocalizedDescription);
					return tempFileUrl;
				}
			}

			NSFileManager.DefaultManager.Move(tempFileUrl.Path, destinationUrl.Path, out error);
			if (error != null)
			{
				Console.WriteLine("Error copying file at {0} to {1}: {2}", tempFileUrl.Path, destinationUrl.Path, error.LocalizedDescription);
				return tempFileUrl;
			}

			return destinationUrl;
		}
	}

	public class UAMediaAttachmentContent
	{
		public NSString Body { get; private set; }
		public NSString Title { get; private set; }
		public NSString Subtitle { get; private set; }

		public static UAMediaAttachmentContent ContentWithDictionary(NSDictionary content)
		{
			UAMediaAttachmentContent attchmentContent = new UAMediaAttachmentContent();
			attchmentContent.Body = (NSString)content["body"];
			attchmentContent.Title = (NSString)content["title"];
			attchmentContent.Subtitle = (NSString)content["subtitle"];
			return attchmentContent;
		}
	}

	public class UAMediaAttachmentPayload
	{
		public List<string> Urls { get; private set; }
		public UNNotificationAttachmentOptions Options { get; private set; }
		public UAMediaAttachmentContent Content { get; private set; }


		public static UAMediaAttachmentPayload PayloadWithJSONObject(NSObject obj)
		{
			NSDictionary jsonPayload = obj as NSDictionary;
			if (jsonPayload == null)
			{
				return null;
			}

			UAMediaAttachmentPayload attachmentPayload = new UAMediaAttachmentPayload();
			attachmentPayload.Urls = ParseUrls(jsonPayload["urls"]);
			attachmentPayload.Options = ParseOptions(jsonPayload["options"]);
			attachmentPayload.Content = ParseContent(jsonPayload["content"]);

			if (attachmentPayload.Urls.Count == 0)
			{
				return null;
			}

			return attachmentPayload;
		}

		private static UAMediaAttachmentContent ParseContent(NSObject contentObj)
		{
			NSDictionary payload = contentObj as NSDictionary;
			if (payload != null)
			{
				return UAMediaAttachmentContent.ContentWithDictionary(payload);
			}

			return null;
		}

		private static UNNotificationAttachmentOptions ParseOptions(NSObject optionsObj)
		{
			NSDictionary optionsPayload = optionsObj as NSDictionary;
			if (optionsPayload == null)
			{
				return null;
			}

			NSDictionary cropPayload = optionsPayload["crop"] as NSDictionary;
			NSNumber time = optionsPayload["time"] as NSNumber;
			NSNumber hidden = optionsPayload["hidden"] as NSNumber;

			UNNotificationAttachmentOptions options = new UNNotificationAttachmentOptions();

			if (time != null)
			{
				options.ThumbnailTime = CoreMedia.CMTime.FromSeconds(time.DoubleValue, 1);
			}

			if (hidden != null)
			{
				options.ThumbnailHidden = hidden.BoolValue;
			}

			if (cropPayload != null)
			{
				CoreGraphics.CGRect crop = new CoreGraphics.CGRect();
				if (CoreGraphics.CGRect.TryParse(cropPayload, out crop))
				{
					options.ThumbnailClippingRect = crop;
				}
			}

			return options;
		}

		private static List<string> ParseUrls(NSObject urlsObject)
		{
			List<string> result = new List<string>();
			if (urlsObject == null)
			{
				return result;
			}

			if (urlsObject is NSString)
			{
				result.Add((NSString)urlsObject);
			}
			else if (urlsObject is NSArray)
			{
				NSArray array = (NSArray)urlsObject;

				for (uint i = 0; i < array.Count; i++)
				{
					NSString url = array.GetItem<NSString>(i);
					if (url != null)
					{
						result.Add(url.ToString());
					}
				}
			}

			return result;
		}

	}

}
