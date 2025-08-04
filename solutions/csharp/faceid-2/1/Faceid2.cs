using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override bool Equals(Object obj) => ReferenceEquals(this, obj) ||  Equals(obj as FacialFeatures);

    public bool Equals(FacialFeatures other) => other != null && EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;

    public override int GetHashCode() => HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override bool Equals(Object obj) => ReferenceEquals(this, obj) || Equals(obj as Identity);

    public bool Equals(Identity other) => other != null && Email.Equals(other.Email) && FacialFeatures.Equals(other.FacialFeatures);

    public override int GetHashCode() => HashCode.Combine(Email, FacialFeatures);
}

public class Authenticator
{
    private readonly Identity _admin = new("admin@exerc.ism", new FacialFeatures("green", 0.9m));

    private readonly HashSet<Identity> _registeredIdentities = new();

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => Equals(faceA, faceB);

    public bool IsAdmin(Identity identity) => identity.Equals(_admin);

    public bool Register(Identity identity) => _registeredIdentities.Add(identity);

    public bool IsRegistered(Identity identity) => _registeredIdentities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => ReferenceEquals(identityA, identityB);
}
