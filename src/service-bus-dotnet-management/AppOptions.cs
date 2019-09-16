// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace AzureServiceBusDotNetManagement
{
    using Microsoft.Azure.Management.ServiceBus.Models;
    using System.Collections.Generic;

    public class AppOptions
    {
        public string TenantId { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string SubscriptionId { get; set; }
        public string DataCenterLocation { get; set; }
        public SkuName ServiceBusSkuName { get; set; }
        public SkuTier? ServiceBusSkuTier { get; set; }
        public string ResourceGr { get; set; }
        public string BusNSpace { get; set; }
        public List<string> Queues { get; set; }

    }
}