// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: buffer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GomokuBuffer {

  /// <summary>Holder for reflection information generated from buffer.proto</summary>
  public static partial class BufferReflection {

    #region Descriptor
    /// <summary>File descriptor for buffer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BufferReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxidWZmZXIucHJvdG8SDGdvbW9rdUJ1ZmZlciI+CgROb2RlEgkKAVgYASAB",
            "KAUSCQoBWRgCIAEoBRIOCgZQbGF5ZXIYAyABKAUSEAoIQ2FwdGVyZWQYBCAB",
            "KAgiLwoNQ0RHYW1lUmVxdWVzdBIOCgZHYW1lSUQYASABKAkSDgoGRGVsZXRl",
            "GAIgASgIIigKEkNoZWNrUnVsZXNSZXNwb25zZRISCgpJc1Bvc3NpYmxlGAEg",
            "ASgIIjQKDkNER2FtZVJlc3BvbnNlEhEKCUlzU3VjY2VzcxgBIAEoCBIPCgdN",
            "ZXNzYWdlGAIgASgJIkwKC1N0b25lUGxheWVkEi0KEUN1cnJlbnRQbGF5ZXJN",
            "b3ZlGAEgASgLMhIuZ29tb2t1QnVmZmVyLk5vZGUSDgoGR2FtZUlEGAIgASgJ",
            "MtwBCgRHYW1lEkUKBkNER2FtZRIbLmdvbW9rdUJ1ZmZlci5DREdhbWVSZXF1",
            "ZXN0GhwuZ29tb2t1QnVmZmVyLkNER2FtZVJlc3BvbnNlIgASQAoGUGxheWVk",
            "EhkuZ29tb2t1QnVmZmVyLlN0b25lUGxheWVkGhkuZ29tb2t1QnVmZmVyLlN0",
            "b25lUGxheWVkIgASSwoKQ2hlY2tSdWxlcxIZLmdvbW9rdUJ1ZmZlci5TdG9u",
            "ZVBsYXllZBogLmdvbW9rdUJ1ZmZlci5DaGVja1J1bGVzUmVzcG9uc2UiAGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GomokuBuffer.Node), global::GomokuBuffer.Node.Parser, new[]{ "X", "Y", "Player", "Captered" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GomokuBuffer.CDGameRequest), global::GomokuBuffer.CDGameRequest.Parser, new[]{ "GameID", "Delete" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GomokuBuffer.CheckRulesResponse), global::GomokuBuffer.CheckRulesResponse.Parser, new[]{ "IsPossible" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GomokuBuffer.CDGameResponse), global::GomokuBuffer.CDGameResponse.Parser, new[]{ "IsSuccess", "Message" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GomokuBuffer.StonePlayed), global::GomokuBuffer.StonePlayed.Parser, new[]{ "CurrentPlayerMove", "GameID" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Node : pb::IMessage<Node> {
    private static readonly pb::MessageParser<Node> _parser = new pb::MessageParser<Node>(() => new Node());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Node> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GomokuBuffer.BufferReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Node() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Node(Node other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      player_ = other.player_;
      captered_ = other.captered_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Node Clone() {
      return new Node(this);
    }

    /// <summary>Field number for the "X" field.</summary>
    public const int XFieldNumber = 1;
    private int x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "Y" field.</summary>
    public const int YFieldNumber = 2;
    private int y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "Player" field.</summary>
    public const int PlayerFieldNumber = 3;
    private int player_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Player {
      get { return player_; }
      set {
        player_ = value;
      }
    }

    /// <summary>Field number for the "Captered" field.</summary>
    public const int CapteredFieldNumber = 4;
    private bool captered_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Captered {
      get { return captered_; }
      set {
        captered_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Node);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Node other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Player != other.Player) return false;
      if (Captered != other.Captered) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0) hash ^= X.GetHashCode();
      if (Y != 0) hash ^= Y.GetHashCode();
      if (Player != 0) hash ^= Player.GetHashCode();
      if (Captered != false) hash ^= Captered.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(X);
      }
      if (Y != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Y);
      }
      if (Player != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Player);
      }
      if (Captered != false) {
        output.WriteRawTag(32);
        output.WriteBool(Captered);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(X);
      }
      if (Y != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Y);
      }
      if (Player != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Player);
      }
      if (Captered != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Node other) {
      if (other == null) {
        return;
      }
      if (other.X != 0) {
        X = other.X;
      }
      if (other.Y != 0) {
        Y = other.Y;
      }
      if (other.Player != 0) {
        Player = other.Player;
      }
      if (other.Captered != false) {
        Captered = other.Captered;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            X = input.ReadInt32();
            break;
          }
          case 16: {
            Y = input.ReadInt32();
            break;
          }
          case 24: {
            Player = input.ReadInt32();
            break;
          }
          case 32: {
            Captered = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CDGameRequest : pb::IMessage<CDGameRequest> {
    private static readonly pb::MessageParser<CDGameRequest> _parser = new pb::MessageParser<CDGameRequest>(() => new CDGameRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CDGameRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GomokuBuffer.BufferReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CDGameRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CDGameRequest(CDGameRequest other) : this() {
      gameID_ = other.gameID_;
      delete_ = other.delete_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CDGameRequest Clone() {
      return new CDGameRequest(this);
    }

    /// <summary>Field number for the "GameID" field.</summary>
    public const int GameIDFieldNumber = 1;
    private string gameID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GameID {
      get { return gameID_; }
      set {
        gameID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Delete" field.</summary>
    public const int DeleteFieldNumber = 2;
    private bool delete_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Delete {
      get { return delete_; }
      set {
        delete_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CDGameRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CDGameRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GameID != other.GameID) return false;
      if (Delete != other.Delete) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (GameID.Length != 0) hash ^= GameID.GetHashCode();
      if (Delete != false) hash ^= Delete.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (GameID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GameID);
      }
      if (Delete != false) {
        output.WriteRawTag(16);
        output.WriteBool(Delete);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (GameID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GameID);
      }
      if (Delete != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CDGameRequest other) {
      if (other == null) {
        return;
      }
      if (other.GameID.Length != 0) {
        GameID = other.GameID;
      }
      if (other.Delete != false) {
        Delete = other.Delete;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            GameID = input.ReadString();
            break;
          }
          case 16: {
            Delete = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CheckRulesResponse : pb::IMessage<CheckRulesResponse> {
    private static readonly pb::MessageParser<CheckRulesResponse> _parser = new pb::MessageParser<CheckRulesResponse>(() => new CheckRulesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CheckRulesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GomokuBuffer.BufferReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckRulesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckRulesResponse(CheckRulesResponse other) : this() {
      isPossible_ = other.isPossible_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckRulesResponse Clone() {
      return new CheckRulesResponse(this);
    }

    /// <summary>Field number for the "IsPossible" field.</summary>
    public const int IsPossibleFieldNumber = 1;
    private bool isPossible_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsPossible {
      get { return isPossible_; }
      set {
        isPossible_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CheckRulesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CheckRulesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsPossible != other.IsPossible) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsPossible != false) hash ^= IsPossible.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IsPossible != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsPossible);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsPossible != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CheckRulesResponse other) {
      if (other == null) {
        return;
      }
      if (other.IsPossible != false) {
        IsPossible = other.IsPossible;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IsPossible = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CDGameResponse : pb::IMessage<CDGameResponse> {
    private static readonly pb::MessageParser<CDGameResponse> _parser = new pb::MessageParser<CDGameResponse>(() => new CDGameResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CDGameResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GomokuBuffer.BufferReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CDGameResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CDGameResponse(CDGameResponse other) : this() {
      isSuccess_ = other.isSuccess_;
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CDGameResponse Clone() {
      return new CDGameResponse(this);
    }

    /// <summary>Field number for the "IsSuccess" field.</summary>
    public const int IsSuccessFieldNumber = 1;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "Message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CDGameResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CDGameResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsSuccess != other.IsSuccess) return false;
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IsSuccess != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsSuccess);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CDGameResponse other) {
      if (other == null) {
        return;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class StonePlayed : pb::IMessage<StonePlayed> {
    private static readonly pb::MessageParser<StonePlayed> _parser = new pb::MessageParser<StonePlayed>(() => new StonePlayed());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StonePlayed> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GomokuBuffer.BufferReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StonePlayed() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StonePlayed(StonePlayed other) : this() {
      currentPlayerMove_ = other.currentPlayerMove_ != null ? other.currentPlayerMove_.Clone() : null;
      gameID_ = other.gameID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StonePlayed Clone() {
      return new StonePlayed(this);
    }

    /// <summary>Field number for the "CurrentPlayerMove" field.</summary>
    public const int CurrentPlayerMoveFieldNumber = 1;
    private global::GomokuBuffer.Node currentPlayerMove_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GomokuBuffer.Node CurrentPlayerMove {
      get { return currentPlayerMove_; }
      set {
        currentPlayerMove_ = value;
      }
    }

    /// <summary>Field number for the "GameID" field.</summary>
    public const int GameIDFieldNumber = 2;
    private string gameID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GameID {
      get { return gameID_; }
      set {
        gameID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StonePlayed);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StonePlayed other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CurrentPlayerMove, other.CurrentPlayerMove)) return false;
      if (GameID != other.GameID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (currentPlayerMove_ != null) hash ^= CurrentPlayerMove.GetHashCode();
      if (GameID.Length != 0) hash ^= GameID.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (currentPlayerMove_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CurrentPlayerMove);
      }
      if (GameID.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(GameID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (currentPlayerMove_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurrentPlayerMove);
      }
      if (GameID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GameID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StonePlayed other) {
      if (other == null) {
        return;
      }
      if (other.currentPlayerMove_ != null) {
        if (currentPlayerMove_ == null) {
          currentPlayerMove_ = new global::GomokuBuffer.Node();
        }
        CurrentPlayerMove.MergeFrom(other.CurrentPlayerMove);
      }
      if (other.GameID.Length != 0) {
        GameID = other.GameID;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (currentPlayerMove_ == null) {
              currentPlayerMove_ = new global::GomokuBuffer.Node();
            }
            input.ReadMessage(currentPlayerMove_);
            break;
          }
          case 18: {
            GameID = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
