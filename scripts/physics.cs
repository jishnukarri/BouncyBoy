using Godot;
using System;
using System.Linq;
public static class PlayTrackInteraction
{
    public static Vector3 FindAccelerationOnASlope(float delta,float CoefficientOfFriction, Vector3 PossitionVectorOfObject, Vector3 PossitionVectorOfSlope, float ObjectMass, float gravity)
    {
        //Compair it to the plane X+z=0
        Vector3 UnitPossitionVectorOdSlope;
        float PossitionVectorOfObjectMagnetude = (PossitionVectorOfSlope.Y * PossitionVectorOfSlope.Y) + (PossitionVectorOfSlope.X * PossitionVectorOfSlope.X) + (PossitionVectorOfSlope.Z * PossitionVectorOfSlope.Z);
        UnitPossitionVectorOdSlope.X = PossitionVectorOfObject.X / PossitionVectorOfObjectMagnetude;
        UnitPossitionVectorOdSlope.Y = PossitionVectorOfObject.X / PossitionVectorOfObjectMagnetude;
        UnitPossitionVectorOdSlope.Z = PossitionVectorOfObject.X / PossitionVectorOfObjectMagnetude;
        Vector3 UnitVectorXZ = new Vector3(); UnitVectorXZ.X = (float)Math.Sqrt(2); UnitVectorXZ.Z = (float)Math.Sqrt(2);
        float CosAlpha = UnitVectorXZ.X * UnitPossitionVectorOdSlope.X + UnitVectorXZ.X * UnitPossitionVectorOdSlope.X + UnitVectorXZ.X * UnitPossitionVectorOdSlope.X;


        float frictionalForceMag = (float)(ObjectMass * gravity * CoefficientOfFriction * CosAlpha);
        float slidingForceMag = (float)(ObjectMass * gravity * Math.Sin(Math.Acos(CosAlpha)));
        //f=ma
        if (slidingForceMag < frictionalForceMag)
            return new Vector3(0, 0, 0);
        else
            return new Vector3(UnitPossitionVectorOdSlope.X * (slidingForceMag - frictionalForceMag), UnitPossitionVectorOdSlope.Y * (slidingForceMag - frictionalForceMag), UnitPossitionVectorOdSlope.Z * (slidingForceMag - frictionalForceMag));
    }
    public static Vector3 rotatePlayerWithObject(float delta, Vector3 PlayerPossision, float rotationalSpeed, Shape3D theShape)
    {
        float sumX = 0;
        float sumY = 0;
        float sumZ = 0;
        for(int i=0; i<theShape.GetDebugMesh().GetFaces().Count(); i++ ){

             sumX += theShape.GetDebugMesh().GetFaces()[i].X / theShape.GetDebugMesh().GetFaces().Count();
             sumY += theShape.GetDebugMesh().GetFaces()[i].Y / theShape.GetDebugMesh().GetFaces().Count();
             sumZ += theShape.GetDebugMesh().GetFaces()[i].Z / theShape.GetDebugMesh().GetFaces().Count();
            
        }
        PlayerPossision.Rotated(new Vector3(sumX, sumY,sumZ).Normalized(), rotationalSpeed / delta);
        return PlayerPossision;
    }

}

