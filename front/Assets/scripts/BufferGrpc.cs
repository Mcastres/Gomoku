// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: buffer.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GomokuBuffer {
  public static partial class Game
  {
    static readonly string __ServiceName = "gomokuBuffer.Game";

    static readonly grpc::Marshaller<global::GomokuBuffer.CDGameRequest> __Marshaller_gomokuBuffer_CDGameRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GomokuBuffer.CDGameRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GomokuBuffer.CDGameResponse> __Marshaller_gomokuBuffer_CDGameResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GomokuBuffer.CDGameResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GomokuBuffer.StonePlayed> __Marshaller_gomokuBuffer_StonePlayed = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GomokuBuffer.StonePlayed.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GomokuBuffer.CheckRulesResponse> __Marshaller_gomokuBuffer_CheckRulesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GomokuBuffer.CheckRulesResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GomokuBuffer.CDGameRequest, global::GomokuBuffer.CDGameResponse> __Method_CDGame = new grpc::Method<global::GomokuBuffer.CDGameRequest, global::GomokuBuffer.CDGameResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CDGame",
        __Marshaller_gomokuBuffer_CDGameRequest,
        __Marshaller_gomokuBuffer_CDGameResponse);

    static readonly grpc::Method<global::GomokuBuffer.StonePlayed, global::GomokuBuffer.StonePlayed> __Method_Played = new grpc::Method<global::GomokuBuffer.StonePlayed, global::GomokuBuffer.StonePlayed>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Played",
        __Marshaller_gomokuBuffer_StonePlayed,
        __Marshaller_gomokuBuffer_StonePlayed);

    static readonly grpc::Method<global::GomokuBuffer.StonePlayed, global::GomokuBuffer.StonePlayed> __Method_PlayedHelp = new grpc::Method<global::GomokuBuffer.StonePlayed, global::GomokuBuffer.StonePlayed>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PlayedHelp",
        __Marshaller_gomokuBuffer_StonePlayed,
        __Marshaller_gomokuBuffer_StonePlayed);

    static readonly grpc::Method<global::GomokuBuffer.StonePlayed, global::GomokuBuffer.CheckRulesResponse> __Method_CheckRules = new grpc::Method<global::GomokuBuffer.StonePlayed, global::GomokuBuffer.CheckRulesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckRules",
        __Marshaller_gomokuBuffer_StonePlayed,
        __Marshaller_gomokuBuffer_CheckRulesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GomokuBuffer.BufferReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Game</summary>
    public abstract partial class GameBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GomokuBuffer.CDGameResponse> CDGame(global::GomokuBuffer.CDGameRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GomokuBuffer.StonePlayed> Played(global::GomokuBuffer.StonePlayed request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GomokuBuffer.StonePlayed> PlayedHelp(global::GomokuBuffer.StonePlayed request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GomokuBuffer.CheckRulesResponse> CheckRules(global::GomokuBuffer.StonePlayed request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Game</summary>
    public partial class GameClient : grpc::ClientBase<GameClient>
    {
      /// <summary>Creates a new client for Game</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GameClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Game that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GameClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GameClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GameClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GomokuBuffer.CDGameResponse CDGame(global::GomokuBuffer.CDGameRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CDGame(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GomokuBuffer.CDGameResponse CDGame(global::GomokuBuffer.CDGameRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CDGame, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GomokuBuffer.CDGameResponse> CDGameAsync(global::GomokuBuffer.CDGameRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CDGameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GomokuBuffer.CDGameResponse> CDGameAsync(global::GomokuBuffer.CDGameRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CDGame, null, options, request);
      }
      public virtual global::GomokuBuffer.StonePlayed Played(global::GomokuBuffer.StonePlayed request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Played(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GomokuBuffer.StonePlayed Played(global::GomokuBuffer.StonePlayed request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Played, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GomokuBuffer.StonePlayed> PlayedAsync(global::GomokuBuffer.StonePlayed request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PlayedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GomokuBuffer.StonePlayed> PlayedAsync(global::GomokuBuffer.StonePlayed request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Played, null, options, request);
      }
      public virtual global::GomokuBuffer.StonePlayed PlayedHelp(global::GomokuBuffer.StonePlayed request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PlayedHelp(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GomokuBuffer.StonePlayed PlayedHelp(global::GomokuBuffer.StonePlayed request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PlayedHelp, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GomokuBuffer.StonePlayed> PlayedHelpAsync(global::GomokuBuffer.StonePlayed request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PlayedHelpAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GomokuBuffer.StonePlayed> PlayedHelpAsync(global::GomokuBuffer.StonePlayed request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PlayedHelp, null, options, request);
      }
      public virtual global::GomokuBuffer.CheckRulesResponse CheckRules(global::GomokuBuffer.StonePlayed request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckRules(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GomokuBuffer.CheckRulesResponse CheckRules(global::GomokuBuffer.StonePlayed request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckRules, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GomokuBuffer.CheckRulesResponse> CheckRulesAsync(global::GomokuBuffer.StonePlayed request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckRulesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GomokuBuffer.CheckRulesResponse> CheckRulesAsync(global::GomokuBuffer.StonePlayed request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckRules, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GameClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GameClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GameBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CDGame, serviceImpl.CDGame)
          .AddMethod(__Method_Played, serviceImpl.Played)
          .AddMethod(__Method_PlayedHelp, serviceImpl.PlayedHelp)
          .AddMethod(__Method_CheckRules, serviceImpl.CheckRules).Build();
    }

  }
}
#endregion
