using UnityEngine;

namespace Roargh.Rev.Floats
{
	public static class RevFloat
	{
		public static float Clamp(this float f, float min, float max) =>
			Mathf.Clamp(f, min, max);

		public static float Abs(this float f) =>
			Mathf.Abs(f);

		public static float Acos(this float f) => Mathf.Acos(f);

		public static bool Aproximately(this float f, float aproximation) =>
			Mathf.Approximately(f, aproximation);

		public static float Asin(this float f) =>
			Mathf.Asin(f);

		public static float Atan(this float f) =>
			Mathf.Atan(f);

		public static float Atan2(this float f, float b) =>
			Mathf.Atan2(f, b);

		public static float Ceil(this float f) =>
			Mathf.Ceil(f);

		public static float CeilToInt(this float f) =>
			Mathf.CeilToInt(f);

		public static float Clamp01(this float f) =>
			Mathf.Clamp01(f);

		public static int ClosestPowerOfTwo(this int i) =>
			Mathf.ClosestPowerOfTwo(i);

		public static Color CorrelatedColorTemperatureToRGB(this float f) =>
			Mathf.CorrelatedColorTemperatureToRGB(f);

		public static float Cos(this float f) =>
			Mathf.Cos(f);

		public static float DeltaAngle(this float f, float target) =>
			Mathf.DeltaAngle(f, target);

		public static float Exp(this float f) =>
			Mathf.Exp(f);

		public static float Floor(this float f) =>
			Mathf.Floor(f);

		public static float FloorToInt(this float f) =>
			Mathf.FloorToInt(f);

		public static float GammaToLinearSpace(this float f) =>
			Mathf.GammaToLinearSpace(f);

		public static float InverseLerp(this float f, float bValue, float t) =>
			Mathf.InverseLerp(f, bValue, t);

		public static bool IsPowerOfTwo(this int i) =>
			Mathf.IsPowerOfTwo(i);

		public static float Lerp(this float f, float bValue, float t) =>
			Mathf.Lerp(f, bValue, t);

		public static float LerpAngle(this float f, float bAngle, float t) =>
			Mathf.LerpAngle(f, bAngle, t);

		public static float LerpUnclamped(this float f, float bValue, float t) =>
			Mathf.LerpUnclamped(f, bValue, t);

		public static float LinearToGammaSpace(this float f) =>
			Mathf.LinearToGammaSpace(f);

		public static float Log(this float f) =>
			Mathf.Log(f);

		public static float Log10(this float f) =>
			Mathf.Log10(f);

		public static float Max(this float f) =>
			Mathf.Max(f);

		public static float Min(this float f) =>
			Mathf.Min(f);

		public static float MoveTowards(this float f, float to, float maxDelta) =>
			Mathf.MoveTowards(f, to, maxDelta);

		public static float MoveTowardsAngle(this float f, float toAngle, float maxDelta) =>
			Mathf.MoveTowardsAngle(f, toAngle, maxDelta);

		public static float NextPowerOfTwo(this int i) =>
			Mathf.NextPowerOfTwo(i);

		//Skiping perlin noise

		public static float PingPong(this float f, float length) =>
			Mathf.PingPong(f, length);

		public static float Pow(this float f, float p) =>
			Mathf.Pow(f, p);

		public static float Repeat(this float f, float length) =>
			Mathf.Repeat(f, length);

		public static float Round(this float f) =>
			Mathf.Round(f);

		public static float RoundToInt(this float f) =>
			Mathf.RoundToInt(f);

		public static float Sign(this float f) =>
			Mathf.Sign(f);

		public static float Sin(this float f) =>
			Mathf.Sin(f);

		public static float SmoothDamp(this float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed) =>
			Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed);

		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed) =>
			Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed);

		public static float SmoothStep(this float from, float to, float t) =>
			Mathf.SmoothStep(from, to, t);

		public static float Sqrt(this float f) =>
			Mathf.Sqrt(f);

		public static float Tan(this float f) =>
			Mathf.Tan(f);

		/// Outside of mathf
		public static float Div(this float f, float divisior)
		{
			// I know it would be thrown anyway but hey. Worth it for new exception message
			if (divisior == 0) throw new System.DivideByZeroException("Don't break the fabric of universe please");
			return f / divisior;
		}

		public static float Sub(this float f, float b) => f - b;

		public static float Add(this float f, float b) => f + b;

		public static float Mul(this float f, float b) => f * b;
	}
}
