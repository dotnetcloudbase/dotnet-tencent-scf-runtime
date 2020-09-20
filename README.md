# dotnet Tencent SCF Runtime

Many modern systems have client components like iOS/android, macOS or watchOS applications as well as server components that those clients interact with. Serverless functions are often the easiest and most efficient way for client application developers to extend their applications into the cloud.

Serverless functions are increasingly becoming a popular choice for running event-driven or otherwise ad-hoc compute tasks in the cloud. They power mission critical microservices and data intensive workloads. In many cases, serverless functions allow developers to more easily scale and control compute costs given their on-demand nature.

When using serverless functions, attention must be given to resource utilization as it directly impacts the costs of the system. This is where dotnet(c#) shines! With its low memory footprint, deterministic performance, and quick start time, dotnet/C# is a fantastic match for the serverless functions architecture.

Combine this with dotnet's developer friendliness, expressiveness, and emphasis on safety, and we have a solution that is great for developers at all skill levels, scalable, and cost effective.

Dotnet Tencent SCF Runtime is base [scf mvp demo](https://github.com/dotnetcloudbase/findjobtclooud) , designed to make building cloud functions in c# simple and safe. The library is an implementation of the [Tencent SCF Custom Runtime API](https://cloud.tencent.com/document/product/583/47274#custom-runtime-.E8.BF.90.E8.A1.8C.E6.97.B6-api) and uses an embedded asynchronous HTTP Client based on  dotnet/httpclient that is fine-tuned for performance in the SCF Custom Runtime context. The library provides a multi-tier API that allows building a range of cloud functions: From quick and simple Closures to complex, performance-sensitive event handlers.
