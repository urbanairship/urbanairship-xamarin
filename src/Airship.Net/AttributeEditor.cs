/* Copyright Airship and Contributors */

namespace AirshipDotNet.Attributes
{
    /// <summary>
    /// Editor for Channel and Named User attributes.
    /// </summary>
    public class AttributeEditor
    {
        private readonly List<IAttributeOperation> operations = new();
        private readonly Action<List<IAttributeOperation>> onApply;

        //@cond IGNORE
        public AttributeEditor(Action<List<IAttributeOperation>> onApply)
        {
            this.onApply = onApply;
        }
        //@endcond

        /// <summary>
        /// Sets a string attribute.
        /// </summary>
        /// <returns>The attribute editor.</returns>
        /// <param name="key">The attribute key.</param>
        /// <param name="value">The attribute value.</param>
        public AttributeEditor SetAttribute(string key, string value)
        {
            operations.Add(new SetAttributeOperation<string>(key, value));
            return this;
        }

        /// <summary>
        /// Sets a float attribute.
        /// </summary>
        /// <returns>The attribute editor.</returns>
        /// <param name="key">The attribute key.</param>
        /// <param name="value">The attribute value.</param>
        public AttributeEditor SetAttribute(string key, float value)
        {
            operations.Add(new SetAttributeOperation<float>(key, value));
            return this;
        }

        /// <summary>
        /// Sets a double attribute.
        /// </summary>
        /// <returns>The attribute editor.</returns>
        /// <param name="key">The attribute key.</param>
        /// <param name="value">The attribute value.</param>
        public AttributeEditor SetAttribute(string key, double value)
        {
            operations.Add(new SetAttributeOperation<double>(key, value));
            return this;
        }

        /// <summary>
        /// Sets an int attribute.
        /// </summary>
        /// <returns>The attribute editor.</returns>
        /// <param name="key">The attribute key.</param>
        /// <param name="value">The attribute value.</param>
        public AttributeEditor SetAttribute(string key, int value)
        {
            operations.Add(new SetAttributeOperation<int>(key, value));
            return this;
        }

        /// <summary>
        /// Sets a long attribute.
        /// </summary>
        /// <returns>The attribute editor.</returns>
        /// <param name="key">The attribute key.</param>
        /// <param name="value">The attribute value.</param>
        public AttributeEditor SetAttribute(string key, long value)
        {
            operations.Add(new SetAttributeOperation<long>(key, value));
            return this;
        }

        /// <summary>
        /// Sets a date attribute.
        /// </summary>
        /// <returns>The attribute editor.</returns>
        /// <param name="key">The attribute key.</param>
        /// <param name="value">The attribute value.</param>
        public AttributeEditor SetAttribute(string key, DateTime value)
        {
            operations.Add(new SetAttributeOperation<DateTime>(key, value));
            return this;
        }

        /// <summary>
        /// Removes an attribute.
        /// </summary>
        /// <returns>The attribute editor.</returns>
        /// <param name="key">The attribute key.</param>
        public AttributeEditor RemoveAttribute(string key)
        {
            operations.Add(new RemoveAttributeOperation(key));
            return this;
        }

        /// <summary>
        /// Apply the attribute edits.
        /// </summary>
        public void Apply()
        {
            onApply?.Invoke(operations);
        }

        //@cond IGNORE

        /// <summary>
        /// Interface representing an attribute editor operation.
        /// </summary>
        /// <returns>The attribute editor.</returns>
        public interface IAttributeOperation
        {
            OperationType OperationType { get; }
            string Key { get; }
        }

        public class SetAttributeOperation<T> : IAttributeOperation
        {
            public OperationType OperationType { get; private set; }
            public string Key { get; private set; }
            public T Value { get; private set; }

            internal SetAttributeOperation(string key, T value)
            {
                OperationType = OperationType.SET;
                Key = key;
                Value = value;
            }
        }

        public class RemoveAttributeOperation : IAttributeOperation
        {
            public OperationType OperationType { get; private set; }
            public string Key { get; private set; }

            internal RemoveAttributeOperation(string key)
            {
                OperationType = OperationType.REMOVE;
                Key = key;
            }
        }

        public enum OperationType { SET, REMOVE }
        //@endcond
    }
}
