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
            "CgxidWZmZXIucHJvdG8SDGdvbW9rdUJ1ZmZlciIsCgROb2RlEgkKAVgYASAB",
            "KAUSCQoBWRgCIAEoBRIOCgZQbGF5ZXIYAyABKAUiSQoLQ29uZmlnUnVsZXMS",
            "HQoVaXNBY3RpdmVSdWxlRnJlZVRocmVlGAEgASgIEhsKE2lzQWN0aXZlUnVs",
            "ZUNhcHR1cmUYAiABKAgiWQoNQ0RHYW1lUmVxdWVzdBIOCgZHYW1lSUQYASAB",
            "KAkSKAoFUnVsZXMYAiABKAsyGS5nb21va3VCdWZmZXIuQ29uZmlnUnVsZXMS",
            "DgoGRGVsZXRlGAMgASgIIowBChJDaGVja1J1bGVzUmVzcG9uc2USEgoKSXNQ",
            "b3NzaWJsZRgBIAEoCBIkCghDYXB0dXJlZBgCIAMoCzISLmdvbW9rdUJ1ZmZl",
            "ci5Ob2RlEhgKEE5iU3RvbmVkQ2FwdHVyZWQYAyABKAUSEwoLUGFydHlGaW5p",
            "c2gYBCABKAgSDQoFV2luSXMYBSABKAUiNAoOQ0RHYW1lUmVzcG9uc2USEQoJ",
            "SXNTdWNjZXNzGAEgASgIEg8KB01lc3NhZ2UYAiABKAkiTAoLU3RvbmVQbGF5",
            "ZWQSLQoRQ3VycmVudFBsYXllck1vdmUYASABKAsyEi5nb21va3VCdWZmZXIu",
            "Tm9kZRIOCgZHYW1lSUQYAiABKAky3AEKBEdhbWUSRQoGQ0RHYW1lEhsuZ29t",
            "b2t1QnVmZmVyLkNER2FtZVJlcXVlc3QaHC5nb21va3VCdWZmZXIuQ0RHYW1l",
            "UmVzcG9uc2UiABJACgZQbGF5ZWQSGS5nb21va3VCdWZmZXIuU3RvbmVQbGF5",
            "ZWQaGS5nb21va3VCdWZmZXIuU3RvbmVQbGF5ZWQiABJLCgpDaGVja1J1bGVz",
            "EhkuZ29tb2t1QnVmZmVyLlN0b25lUGxheWVkGiAuZ29tb2t1QnVmZmVyLkNo",
            "ZWNrUnVsZXNSZXNwb25zZSIAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GomokuBuffer.Node), global::GomokuBuffer.Node.Parser, new[]{ "X", "Y", "Player" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GomokuBuffer.ConfigRules), global::GomokuBuffer.ConfigRules.Parser, new[]{ "IsActiveRuleFreeThree", "IsActiveRuleCapture" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GomokuBuffer.CDGameRequest), global::GomokuBuffer.CDGameRequest.Parser, new[]{ "GameID", "Rules", "Delete" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GomokuBuffer.CheckRulesResponse), global::GomokuBuffer.CheckRulesResponse.Parser, new[]{ "IsPossible", "Captured", "NbStonedCaptured", "PartyFinish", "WinIs" }, null, null, null),
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
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0) hash ^= X.GetHashCode();
      if (Y != 0) hash ^= Y.GetHashCode();
      if (Player != 0) hash ^= Player.GetHashCode();
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
        }
      }
    }

  }

  public sealed partial class ConfigRules : pb::IMessage<ConfigRules> {
    private static readonly pb::MessageParser<ConfigRules> _parser = new pb::MessageParser<ConfigRules>(() => new ConfigRules());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConfigRules> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GomokuBuffer.BufferReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigRules() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigRules(ConfigRules other) : this() {
      isActiveRuleFreeThree_ = other.isActiveRuleFreeThree_;
      isActiveRuleCapture_ = other.isActiveRuleCapture_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigRules Clone() {
      return new ConfigRules(this);
    }

    /// <summary>Field number for the "isActiveRuleFreeThree" field.</summary>
    public const int IsActiveRuleFreeThreeFieldNumber = 1;
    private bool isActiveRuleFreeThree_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsActiveRuleFreeThree {
      get { return isActiveRuleFreeThree_; }
      set {
        isActiveRuleFreeThree_ = value;
      }
    }

    /// <summary>Field number for the "isActiveRuleCapture" field.</summary>
    public const int IsActiveRuleCaptureFieldNumber = 2;
    private bool isActiveRuleCapture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsActiveRuleCapture {
      get { return isActiveRuleCapture_; }
      set {
        isActiveRuleCapture_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConfigRules);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConfigRules other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsActiveRuleFreeThree != other.IsActiveRuleFreeThree) return false;
      if (IsActiveRuleCapture != other.IsActiveRuleCapture) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsActiveRuleFreeThree != false) hash ^= IsActiveRuleFreeThree.GetHashCode();
      if (IsActiveRuleCapture != false) hash ^= IsActiveRuleCapture.GetHashCode();
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
      if (IsActiveRuleFreeThree != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsActiveRuleFreeThree);
      }
      if (IsActiveRuleCapture != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsActiveRuleCapture);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsActiveRuleFreeThree != false) {
        size += 1 + 1;
      }
      if (IsActiveRuleCapture != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConfigRules other) {
      if (other == null) {
        return;
      }
      if (other.IsActiveRuleFreeThree != false) {
        IsActiveRuleFreeThree = other.IsActiveRuleFreeThree;
      }
      if (other.IsActiveRuleCapture != false) {
        IsActiveRuleCapture = other.IsActiveRuleCapture;
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
            IsActiveRuleFreeThree = input.ReadBool();
            break;
          }
          case 16: {
            IsActiveRuleCapture = input.ReadBool();
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
      get { return global::GomokuBuffer.BufferReflection.Descriptor.MessageTypes[2]; }
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
      rules_ = other.rules_ != null ? other.rules_.Clone() : null;
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

    /// <summary>Field number for the "Rules" field.</summary>
    public const int RulesFieldNumber = 2;
    private global::GomokuBuffer.ConfigRules rules_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GomokuBuffer.ConfigRules Rules {
      get { return rules_; }
      set {
        rules_ = value;
      }
    }

    /// <summary>Field number for the "Delete" field.</summary>
    public const int DeleteFieldNumber = 3;
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
      if (!object.Equals(Rules, other.Rules)) return false;
      if (Delete != other.Delete) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (GameID.Length != 0) hash ^= GameID.GetHashCode();
      if (rules_ != null) hash ^= Rules.GetHashCode();
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
      if (rules_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Rules);
      }
      if (Delete != false) {
        output.WriteRawTag(24);
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
      if (rules_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rules);
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
      if (other.rules_ != null) {
        if (rules_ == null) {
          rules_ = new global::GomokuBuffer.ConfigRules();
        }
        Rules.MergeFrom(other.Rules);
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
          case 18: {
            if (rules_ == null) {
              rules_ = new global::GomokuBuffer.ConfigRules();
            }
            input.ReadMessage(rules_);
            break;
          }
          case 24: {
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
      get { return global::GomokuBuffer.BufferReflection.Descriptor.MessageTypes[3]; }
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
      captured_ = other.captured_.Clone();
      nbStonedCaptured_ = other.nbStonedCaptured_;
      partyFinish_ = other.partyFinish_;
      winIs_ = other.winIs_;
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

    /// <summary>Field number for the "Captured" field.</summary>
    public const int CapturedFieldNumber = 2;
    private static readonly pb::FieldCodec<global::GomokuBuffer.Node> _repeated_captured_codec
        = pb::FieldCodec.ForMessage(18, global::GomokuBuffer.Node.Parser);
    private readonly pbc::RepeatedField<global::GomokuBuffer.Node> captured_ = new pbc::RepeatedField<global::GomokuBuffer.Node>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GomokuBuffer.Node> Captured {
      get { return captured_; }
    }

    /// <summary>Field number for the "NbStonedCaptured" field.</summary>
    public const int NbStonedCapturedFieldNumber = 3;
    private int nbStonedCaptured_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NbStonedCaptured {
      get { return nbStonedCaptured_; }
      set {
        nbStonedCaptured_ = value;
      }
    }

    /// <summary>Field number for the "PartyFinish" field.</summary>
    public const int PartyFinishFieldNumber = 4;
    private bool partyFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PartyFinish {
      get { return partyFinish_; }
      set {
        partyFinish_ = value;
      }
    }

    /// <summary>Field number for the "WinIs" field.</summary>
    public const int WinIsFieldNumber = 5;
    private int winIs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int WinIs {
      get { return winIs_; }
      set {
        winIs_ = value;
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
      if(!captured_.Equals(other.captured_)) return false;
      if (NbStonedCaptured != other.NbStonedCaptured) return false;
      if (PartyFinish != other.PartyFinish) return false;
      if (WinIs != other.WinIs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsPossible != false) hash ^= IsPossible.GetHashCode();
      hash ^= captured_.GetHashCode();
      if (NbStonedCaptured != 0) hash ^= NbStonedCaptured.GetHashCode();
      if (PartyFinish != false) hash ^= PartyFinish.GetHashCode();
      if (WinIs != 0) hash ^= WinIs.GetHashCode();
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
      captured_.WriteTo(output, _repeated_captured_codec);
      if (NbStonedCaptured != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(NbStonedCaptured);
      }
      if (PartyFinish != false) {
        output.WriteRawTag(32);
        output.WriteBool(PartyFinish);
      }
      if (WinIs != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(WinIs);
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
      size += captured_.CalculateSize(_repeated_captured_codec);
      if (NbStonedCaptured != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NbStonedCaptured);
      }
      if (PartyFinish != false) {
        size += 1 + 1;
      }
      if (WinIs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(WinIs);
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
      captured_.Add(other.captured_);
      if (other.NbStonedCaptured != 0) {
        NbStonedCaptured = other.NbStonedCaptured;
      }
      if (other.PartyFinish != false) {
        PartyFinish = other.PartyFinish;
      }
      if (other.WinIs != 0) {
        WinIs = other.WinIs;
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
          case 18: {
            captured_.AddEntriesFrom(input, _repeated_captured_codec);
            break;
          }
          case 24: {
            NbStonedCaptured = input.ReadInt32();
            break;
          }
          case 32: {
            PartyFinish = input.ReadBool();
            break;
          }
          case 40: {
            WinIs = input.ReadInt32();
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
      get { return global::GomokuBuffer.BufferReflection.Descriptor.MessageTypes[4]; }
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
      get { return global::GomokuBuffer.BufferReflection.Descriptor.MessageTypes[5]; }
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
