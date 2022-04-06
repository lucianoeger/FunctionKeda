using System;
using System.Threading;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionKeda
{
    public static class FunctionProduct
    {
        [FunctionName("FunctionProduct")]
        public static void Run([ServiceBusTrigger("queue-product-added-updated", Connection = "ServiceBusConnection")]string product, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {product}");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
