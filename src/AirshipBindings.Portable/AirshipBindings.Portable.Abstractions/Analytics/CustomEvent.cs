/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace UrbanAirship.Portable.Analytics
{
	/// <summary>
	/// A Custom Event model object.
	/// </summary>
	public class CustomEvent
	{
		private string eventName;
		private string eventValue;
		private string transactionId;
		private string interactionType;
		private string interactionId;

		private List<IProperty> propertyList;

		/// <summary>
		/// Initializes a new instance of the <see cref="CustomEvent"/> class.
		/// </summary>
		public CustomEvent()
		{
			this.propertyList = new List<IProperty>();
		}

		/// <summary>
		/// Gets or sets the name of the event.
		/// </summary>
		/// <value>The name of the event.</value>
		public string EventName
		{
			get { return eventName; }
			set { eventName = value; }
		}

		/// <summary>
		/// Gets or sets the event value.
		/// </summary>
		/// <value>The event value.</value>
		public double EventValue
		{
			get { return Double.Parse(eventValue); }
			set { eventValue = value.ToString(); }
		}

		/// <summary>
		/// Gets or sets the transaction identifier.
		/// </summary>
		/// <value>The transaction identifier.</value>
		public string TransactionId
		{
			get { return transactionId; }
			set { transactionId = value; }
		}

		/// <summary>
		/// Gets or sets interaction type.
		/// </summary>
		/// <value>The interaction type.</value>
		public string InteractionType
		{
			get { return interactionType; }
			set { interactionType = value; }
		}

		/// <summary>
		/// Gets or sets the interaction identifier.
		/// </summary>
		/// <value>The interaction identifier.</value>
		public string InteractionId
		{
			get { return interactionId; }
			set { interactionId = value; }
		}

		/// <summary>
		/// Gets a list of properties.
		/// </summary>
		/// <value>The property list.</value>
		public List<IProperty> PropertyList
		{
			get { return propertyList; }
		}

		/// <summary>
		/// Adds a string property.
		/// </summary>
		/// <param name="name">The property name.</param>
		/// <param name="value">The property value.</param>
		public void AddProperty(string name, string value)
		{
			this.propertyList.Add(new Property<string>(name, value));
		}

		/// <summary>
		/// Adds a double property.
		/// </summary>
		/// <param name="name">The property name.</param>
		/// <param name="value">The property value.</param>
		public void AddProperty(string name, double value)
		{
			this.propertyList.Add(new Property<double>(name, value));
		}

		/// <summary>
		/// Adds a bool property.
		/// </summary>
		/// <param name="name">The property name.</param>
		/// <param name="value">The property value.</param>
		public void AddProperty(string name, bool value)
		{
			this.propertyList.Add(new Property<bool>(name, value));
		}

		/// <summary>
		/// Adds a string array property.
		/// </summary>
		/// <param name="name">The property name.</param>
		/// <param name="value">The property value.</param>
		public void AddProperty(string name, ICollection<string> value)
		{
			this.propertyList.Add(new Property<string[]>(name, value.ToArray()));
		}

		public class Property<T> : IProperty
		{
			public string name;
			public T value;

			public Property(string name, T value)
			{
				this.name = name;
				this.value = value;
			}
		}

		public interface IProperty 
		{
			
		}
	}
}