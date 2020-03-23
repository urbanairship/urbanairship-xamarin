/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;

namespace UrbanAirship.NETStandard.Attributes
{
    public class AttributeEditor
    {
        private List<IAttributeOperation> operations = new List<IAttributeOperation>();
        private Action<List<IAttributeOperation>> onApply;

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
            if (onApply != null)
            {
                onApply(operations);
            }
        }

        //@cond IGNORE

        /// <summary>
        /// Interface representing an attribute editor operation.
        /// </summary>
        /// <returns>The attribute editor.</returns>
        /// <param name="key">The attribute key.</param>
        public interface IAttributeOperation
        {
            OperationType operationType { get; }
            string key { get; }
        }

        public class SetAttributeOperation<T> : IAttributeOperation
        {
            public OperationType operationType { get; private set; }
            public string key { get; private set; }
            public T value { get; private set; }

            internal SetAttributeOperation(string key, T value)
            {
                this.operationType = OperationType.SET;
                this.key = key;
                this.value = value;
            }
        }

        public class RemoveAttributeOperation : IAttributeOperation
        {
            public OperationType operationType { get; private set; }
            public string key { get; private set; }

            internal RemoveAttributeOperation(string key)
            {
                this.operationType = OperationType.REMOVE;
                this.key = key;
            }
        }

        public enum OperationType { SET, REMOVE }
        //@endcond
    }
}
