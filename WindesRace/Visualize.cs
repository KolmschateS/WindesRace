using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindesRace
{
    public static class Visualize
    {

        public static void Initialize()
        {

        }

        #region graphics

        private static string[] _finishHorizontal = {
            "----",
            "  # ",
            "  # ",
            "----" };

        private static string[] _startGrid = {
            "----",
            "   ]",
            " ]  ",
            "----" };

        private static string[] _TrackHorizontal = {
            "----",
            "    ",
            "    ",
            "----" };

        private static string[] _TrackVertical = {
            "|  |",
            "|  |",
            "|  |",
            "|  |" };

        private static string[] _TurnLeft = {
            "--'\' ",
            "   '\'",
            "   |",
            "'\'  |" };


        #endregion

        public static void DrawTrack(Track _track)
        {
            string[] _drawing = { "", "", "", "" };
            foreach (Section _section in _track.Sections)
            {

            }
            for(int i = 0; i < _drawing.Length; i++)
            {
                Console.WriteLine(_drawing[i]);
            }
        }
    }
}