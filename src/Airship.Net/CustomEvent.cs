/* Copyright Airship and Contributors */

namespace Airship.Net.Analytics
{
    /// <summary>
    /// A Custom Event model object.
    /// </summary>
    public class CustomEvent
    {
        // FIXME: should it be nullable or should we fix constructor?
        private string? eventValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEvent"/> class.
        /// </summary>
        public CustomEvent()
        {
            PropertyList = new List<IProperty>();
        }

        /// <summary>
        /// Gets or sets the name of the event.
        /// </summary>
        /// <value>The name of the event.</value>
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets the event value.
        /// </summary>
        /// <value>The event value.</value>
        public double EventValue
        {
            get => double.Parse(eventValue);
            set => eventValue = value.ToString();
        }

        /// <summary>
        /// Gets or sets the transaction identifier.
        /// </summary>
        /// <value>The transaction identifier.</value>
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the interaction type.
        /// </summary>
        /// <value>The interaction type.</value>
        public string InteractionType { get; set; }

        /// <summary>
        /// Gets or sets the interaction identifier.
        /// </summary>
        /// <value>The interaction identifier.</value>
        public string InteractionId { get; set; }

        /// <summary>
        /// Gets a list of properties.
        /// </summary>
        /// <value>The property list.</value>
        public List<IProperty> PropertyList { get; private set; }

        /// <summary>
        /// Adds a string property.
        /// </summary>
        /// <param name="name">The property name.</param>
        /// <param name="value">The property value.</param>
        public void AddProperty(string name, string value)
        {
            PropertyList.Add(new Property<string>(name, value));
        }

        /// <summary>
        /// Adds a double property.
        /// </summary>
        /// <param name="name">The property name.</param>
        /// <param name="value">The property value.</param>
        public void AddProperty(string name, double value)
        {
            PropertyList.Add(new Property<double>(name, value));
        }

        /// <summary>
        /// Adds a bool property.
        /// </summary>
        /// <param name="name">The property name.</param>
        /// <param name="value">The property value.</param>
        public void AddProperty(string name, bool value)
        {
            PropertyList.Add(new Property<bool>(name, value));
        }

        /// <summary>
        /// Adds a string array property.
        /// </summary>
        /// <param name="name">The property name.</param>
        /// <param name="value">The property value.</param>
        public void AddProperty(string name, ICollection<string> value)
        {
            PropertyList.Add(new Property<string[]>(name, value.ToArray()));
        }

        //@cond IGNORE

        public class Property<T> : IProperty
        {
            public string Name { get; private set; }
            public T Value { get; private set; }

            public Property(string name, T value)
            {
                Name = name;
                Value = value;
            }
        }

        public interface IProperty
        {
            string Name { get; }
        }

        //@endcond
    }
}
