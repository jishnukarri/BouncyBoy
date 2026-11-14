using Godot;
using System;
public partial class NewScript: Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{}
}
public static class PlayTrackInteraction
{
	
	public static Vector3 FindAccelerationOnASlope(float CoefficientOfFriction, Vector3 PossitionVectorOfObject, Vector3 PossitionVectorOfSlope, float ObjectMass, float gravity)
	{
		//Compair it to the plane X+z=0
		Vector3 UnitPossitionVectorOdSlope;
		float PossitionVectorOfObjectMagnetude = (PossitionVectorOfSlope.Y * PossitionVectorOfSlope.Y) + (PossitionVectorOfSlope.X * PossitionVectorOfSlope.X) + (PossitionVectorOfSlope.Z * PossitionVectorOfSlope.Z);
		UnitPossitionVectorOdSlope.X = PossitionVectorOfObject.X / PossitionVectorOfObjectMagnetude;
		UnitPossitionVectorOdSlope.Y = PossitionVectorOfObject.X / PossitionVectorOfObjectMagnetude;
		UnitPossitionVectorOdSlope.Z = PossitionVectorOfObject.X / PossitionVectorOfObjectMagnetude;
		Vector3 UnitVectorXZ = new Vector3();
		UnitVectorXZ.X = (float) Math.Sqrt(2);
		UnitVectorXZ.Z = (float) Math.Sqrt(2);
		float CosAlpha = UnitVectorXZ.X * UnitPossitionVectorOdSlope.X + UnitVectorXZ.X * UnitPossitionVectorOdSlope.X + UnitVectorXZ.X * UnitPossitionVectorOdSlope.X;
		float frictionalForceMag = (float)(ObjectMass * gravity * CoefficientOfFriction * CosAlpha);
		float slidingForceMag = (float)(ObjectMass * gravity * Math.Sin(Math.Acos(CosAlpha)));
		//f=ma
		if (slidingForceMag < frictionalForceMag) return new Vector3(0, 0, 0);
		else return new Vector3(UnitPossitionVectorOdSlope.X * (slidingForceMag - frictionalForceMag), UnitPossitionVectorOdSlope.Y * (slidingForceMag - frictionalForceMag), UnitPossitionVectorOdSlope.Z * (slidingForceMag - frictionalForceMag));
	}
	public static Vector3(Vector3 PlayerPossision, float rotationalSpeed, Shape3D theShape)
		{
			float sumX =0;
			float sumY =0;
			float sumZ =0;
			foreach(Vector3 vector in theShape.GetDebugMesh().)
			{
				sumX += theShape.PackedVector3Array[Vector].X/ TheShape.PackedVector3Array.count();
				sumY += theShape.PackedVector3Array[Vector].Y/ TheShape.PackedVector3Array.count();
				sumZ += theShape.PackedVector3Array[Vector].Z/ TheShape.PackedVector3Array.count();
			}
			 playerPossision.rotate(new vector3(sumX,sumY.sumZ).normalise,rotationalSpeed/delta  );
			

			return playerPossision;
		}
	//public static Vector3(Vector3 PlayerPossision, Vector3 AboutVector, Vector3 RotationalVelocity)
	//{
		//foreach(Vector3 vector in )
		//return
	//}
	// public static Vector3 RodriguesRotationalFormula(double Theta, Vector3 AboutVectorN, Vector3 VectorMovingV)
	// {
	//     double[] Comp1;
	//     double[] Comp2;
	//     double[] Comp3;
	//     Comp1 = [(1 - Math.Cos(Theta)) * VectorMovingV.dotProduct(AboutVectorN) * AboutVectorN._data[0, 0], (1 - Math.Cos(Theta)) * VectorMovingV.dotProduct(AboutVectorN) * AboutVectorN._data[1, 0], (1 - Math.Cos(Theta)) * VectorMovingV.dotProduct(AboutVectorN) * AboutVectorN._data[2, 0]];
	//     Comp2 = [Math.Cos(Theta) * VectorMovingV._data[0, 0], Math.Cos(Theta) * VectorMovingV._data[1, 0], Math.Cos(Theta) * VectorMovingV._data[2, 0]];
	//     Comp3 = [Math.Sin(Theta) * AboutVectorN.CrossProduct(VectorMovingV)._data[0, 0], Math.Sin(Theta) * AboutVectorN.CrossProduct(VectorMovingV)._data[1, 0], Math.Sin(Theta) * AboutVectorN.CrossProduct(VectorMovingV)._data[2, 0]];
	//     float[] NewPlace = [(float)(Comp1[0] + Comp2[0] + Comp3[0]), (float)(Comp1[1] + Comp2[1] + Comp3[1]), (float)(Comp1[2] + Comp2[2] + Comp3[2])];
	//     return new Vector3(NewPlace);
	// }
}
