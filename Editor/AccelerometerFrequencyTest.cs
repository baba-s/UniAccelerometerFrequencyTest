using NUnit.Framework;
using UnityEditor;

namespace Kogane.Internal
{
	internal sealed class AccelerometerFrequencyTest
	{
		[Category( nameof( Kogane ) )]
		[Test]
		public void 加速度センサーが無効になっているか()
		{
			Assert.IsTrue( PlayerSettings.accelerometerFrequency == 0 );
		}
	}
}