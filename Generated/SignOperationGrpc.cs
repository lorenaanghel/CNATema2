// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NameOperation.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Generated {
  public static partial class SignOperationService
  {
    static readonly string __ServiceName = "SignOperationService";

    static readonly grpc::Marshaller<global::Generated.SignRequest> __Marshaller_NameRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Generated.SignRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Generated.OperationResponse> __Marshaller_OperationResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Generated.OperationResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Generated.SignRequest, global::Generated.OperationResponse> __Method_SayHello = new grpc::Method<global::Generated.SignRequest, global::Generated.OperationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_NameRequest,
        __Marshaller_OperationResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Generated.SignOperationReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SignOperationService</summary>
    [grpc::BindServiceMethod(typeof(SignOperationService), "BindService")]
    public abstract partial class NameOperationServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Generated.OperationResponse> SayHello(global::Generated.SignRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SignOperationService</summary>
    public partial class NameOperationServiceClient : grpc::ClientBase<NameOperationServiceClient>
    {
      /// <summary>Creates a new client for SignOperationService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public NameOperationServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SignOperationService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public NameOperationServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected NameOperationServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected NameOperationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Generated.OperationResponse SayHello(global::Generated.SignRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Generated.OperationResponse SayHello(global::Generated.SignRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Generated.OperationResponse> SayHelloAsync(global::Generated.SignRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Generated.OperationResponse> SayHelloAsync(global::Generated.SignRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override NameOperationServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new NameOperationServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(NameOperationServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, NameOperationServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Generated.SignRequest, global::Generated.OperationResponse>(serviceImpl.SayHello));
    }

  }
}
#endregion
