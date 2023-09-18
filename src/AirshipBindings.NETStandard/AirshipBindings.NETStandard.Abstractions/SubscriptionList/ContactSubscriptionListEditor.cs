/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;


namespace UrbanAirship.NETStandard.Contact
{
    /// <summary>
    /// Interface used to subscribe/unsubscribe from a list.
    /// </summary>
    public class SubscriptionListEditor
    {
        private List<SubscriptionListOperation> operations = new List<SubscriptionListOperation>();
        private Action<List<SubscriptionListOperation>> onApply;

        //@cond IGNORE
        public SubscriptionListEditor(Action<List<SubscriptionListOperation>> onApply)
        {
            this.onApply = onApply;
        }
        //@endcond

        /// <summary>
        /// ASubscribe to a given tag list.
        /// </summary>
        /// <returns>The subscriotion list editor.</returns>
        /// <param name="list">The subscription list identifier to subscribe to.</param>
        /// <param name="list">scope to subscribe scope.</param>
        public SubscriptionListEditor Subscribe(string list, String scope)
        {
            operations.Add(new SubscriptionListOperation(OperationType.SUBSCRIBE, list, scope));
            return this;

        }

        /// <summary>
        /// Unsubscribe from a given list.
        /// </summary>
        /// <returns>The subscriotion list editor.</returns>
        /// <param name="group">The subscription list identifier to unsubscribe from.</param>
        /// <param name="list">scope to scope.</param>
        public SubscriptionListEditor Unsubscribe(string list, String scope)
        {
            operations.Add(new SubscriptionListOperation(OperationType.UNSUBSCRIBE, list, scope));
            return this;
        }

        /// <summary>
        /// Apply the tag group changes.
        /// </summary>
        public void Apply()
        {
            if (onApply != null)
            {
                onApply(operations);
            }
        }

        //@cond IGNORE
        public class SubscriptionListOperation
        {
            public OperationType operationType;
            public string list;
            public string scope;

            internal SubscriptionListOperation(OperationType operation, string list, String scope)
            {
                this.operationType = operation;
                this.list = list;
                this.scope = scope;
            }
        }

        public enum OperationType { SUBSCRIBE, UNSUBSCRIBE }
        //@endcond
    }
}
