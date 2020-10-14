using Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerTest
{
    [TestFixture]
    public class Model_Competition_NextTrackShould
    {
        private Competition _competition;
        private Track _result;

        [SetUp]
        public void SetUp()
        {
            _competition = new Competition();
        }

        [Test]
        public void NextTrack_EmptyQueue_ReturnNull()
        {
            _result = _competition.NextTrack();
            Assert.IsNull(_result);
        }

        [Test]
        public void NextTrack_OneInQueue_ReturnTrack()
        {
            Track _testTrack = new Track("Amersfoort", new LinkedList<Section>());
            _competition.Tracks.Enqueue(_testTrack);
            _result = _competition.NextTrack();
            Assert.AreEqual(_testTrack, _result);
        }
        [Test]
        public void NextTrack_OneInQueue_RemoveTrackFromQueue()
        {
            Track _testTrack = new Track("TestTrack", new LinkedList<Section>());
            _competition.Tracks.Enqueue(_testTrack);
            _result = _competition.NextTrack();
            _result = _competition.NextTrack();
            Assert.IsNull(_result);
        }
        [Test]
        public void NextTrack_TwoInQueue_ReturnNextTrack()
        {
            Track _testTrack = new Track("TestTrack", new LinkedList<Section>());
            _competition.Tracks.Enqueue(_testTrack);
            Track _testTrack2 = new Track("TestTrack2", new LinkedList<Section>());
            _competition.Tracks.Enqueue(_testTrack);

            _result = _competition.NextTrack();
            _competition.Tracks.Dequeue();
            Track _result2 = _competition.NextTrack();
            Assert.AreNotEqual(_result, _result2);

        }
    }
}
