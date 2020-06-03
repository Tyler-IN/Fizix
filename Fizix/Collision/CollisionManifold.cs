using System.Numerics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Fizix {

  // TODO: not implemented
  [PublicAPI]
  public struct CollisionManifold {

    public ContactPoint ContactA, ContactB;

    public PointF Center;

    public Vector2 Normal;

    public bool AlongFace;
    
    public bool OnCorner {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get => !AlongFace;
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set => AlongFace = !value;
    }

  }

  // TODO: not implemented
  [PublicAPI]
  public struct ContactPoint {

    public PointF Point;

    public float NormalImpulse;

    public float TangentImpulse;

  }

}