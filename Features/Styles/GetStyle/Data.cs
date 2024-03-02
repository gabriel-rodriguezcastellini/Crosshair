namespace Crosshair.Features.Styles.GetStyle;

public static class Data
{
    internal static Response GetStyle()
    {
        Array crosshairStyles = Enum.GetValues(typeof(CrosshairStyle));
        Random random = new();

        return new()
        {
            CrosshairStyle = (CrosshairStyle)crosshairStyles.GetValue(random.Next(crosshairStyles.Length))!,
            FriendlyFireReticleWarning = random.NextDouble() >= 0.5,
            FollowRecoil = random.NextDouble() >= 0.5,
            CenterDot = random.NextDouble() >= 0.5,
            Length = random.Next(0, 10),
            Thickness = random.Next(1, 6),
            Gap = random.Next(-5, 5),
            Outline = new()
            {
                YesNo = random.NextDouble() >= 0.5,
                Value = random.Next(0, 3)
            },
            Red = random.Next(0, 255),
            Green = random.Next(0, 255),
            Blue = random.Next(0, 255),
            Alpha = new()
            {
                YesNo = random.NextDouble() >= 0.5,
                Value = random.Next(0, 255)
            },
            SplitDistance = random.Next(0, 16),
            InnerSplitAlpha = Math.Round((decimal)random.NextDouble(), 1),
            OuterSplitAlpha = 1,
            SplitSizeRatio = Math.Round((decimal)random.NextDouble(), 1),
            TStyle = random.NextDouble() >= 0.5,
            DeployedWeaponGap = random.NextDouble() >= 0.5
        };
    }
}
