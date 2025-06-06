using System.Runtime.Serialization;

namespace ScoutingApi.Models.Enums
{
    public enum LocalCorpo
    {
        [EnumMember(Value = "JL")]
        Joelho,

        [EnumMember(Value = "TB")]
        TornozeloBraco,

        [EnumMember(Value = "CM")]
        CoxaMusculo,

        [EnumMember(Value = "OM")]
        Ombro,

        [EnumMember(Value = "CT")]
        Costas,

        [EnumMember(Value = "OT")]
        Outro
    }
}