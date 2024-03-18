﻿using KafkaDemo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, collection) =>
    {
        collection.AddHostedService<KafkaConsumerHostedService>(); 
        collection.AddHostedService<KafkaProducerHostedService>();
    });

CreateHostBuilder(args).Build().Run();