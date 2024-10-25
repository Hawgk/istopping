﻿namespace IRDC
{
    public class ResultsModel
    {
        private string _name = string.Empty;
        private string _class = string.Empty;
        private string _carPath = string.Empty;
        private string _license = string.Empty;

        private int _rating;
        private int _classPosition;
        private int _lapsCompleted;

        private float _fastestLapTime;
        private float _lastLapTime;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }
        public string CarPath
        {
            get { return _carPath; }
            set { _carPath = value; }
        }
        public string License
        {
            get { return _license; }
            set { _license = value; }
        }

        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public int ClassPosition
        {
            get { return _classPosition; }
            set { _classPosition = value; }
        }
        public int LapsCompleted
        {
            get { return _lapsCompleted; }
            set { _lapsCompleted = value; }
        }

        public float FastestLapTime
        {
            get { return _fastestLapTime; }
            set { _fastestLapTime = value; }
        }
        public float LastLapTime
        {
            get { return _lastLapTime; }
            set { _lastLapTime = value; }
        }
    }
}
