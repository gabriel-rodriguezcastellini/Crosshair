namespace Crosshair.Features.Styles.GetStyle;

internal sealed class Response
{
    public CrosshairStyle CrosshairStyle { get; set; }

    public bool FriendlyFireReticleWarning { get; set; }

    public bool FollowRecoil { get; set; }

    public bool CenterDot { get; set; }

    public int Length { get; set; }

    public int Thickness { get; set; }

    public int Gap { get; set; }

    public required Outline Outline { get; set; }

    public int Red { get; set; }

    public int Green { get; set; }

    public int Blue { get; set; }

    public required Alpha Alpha { get; set; }

    public int SplitDistance { get; set; }

    public decimal InnerSplitAlpha { get; set; }

    public int OuterSplitAlpha { get; set; }

    public decimal SplitSizeRatio { get; set; }

    public bool TStyle { get; set; }

    public bool DeployedWeaponGap { get; set; }
}

internal enum CrosshairStyle
{
    Classic,
    ClassicStatic,
    Legacy
}

internal sealed class Outline
{
    public bool YesNo { get; set; }

    public decimal Value { get; set; }
}

internal sealed class Alpha
{
    public bool YesNo { get; set; }

    public int Value { get; set; }
}