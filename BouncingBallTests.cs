using NUnit.Framework;

namespace CodeWarsKata
{
    public class BouncingBallTests
    {
        private BouncingBall _bouncingBall = new BouncingBall();

        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, _bouncingBall.bouncingBall(3.0, 0.66, 1.5));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(15, _bouncingBall.bouncingBall(30.0, 0.66, 1.5));
        }

        [Test]
        public void h1_1_w1_1()
        {
            Assert.AreEqual(1, _bouncingBall.bouncingBall(1.1, 0.66, 1));
        }

        [Test]
        public void h2_w1_3()
        {
            Assert.AreEqual(3, _bouncingBall.bouncingBall(2, 0.66, 1));
        }

        [Test]
        public void h4_w1_7()
        {
            Assert.AreEqual(7, _bouncingBall.bouncingBall(4, 0.66, 1));
        }
    }

    public class BouncingBall
    {
        public int bouncingBall(double h, double bounce, double window)
        {
            var count = 0;
            if (!(h > 0) || !(bounce > 0) || !(bounce < 1) || !(window < h)) return -1;
            count++;
            do
            {
                h *= bounce;
                if (h >= window)
                {
                    count += 2;
                }
            } while (h >= window);
            return count;
        }
    }
}