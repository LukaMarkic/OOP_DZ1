using System;

namespace ClassLibraryOOP_DZ1
{
    public class Episode
    {
        public int viewer = 0;
        float sumOfScores = 0;
        float maxScore;


        int i;

        float[] scores = new float[20];
        public Episode() { }
        public Episode(int viewer, double sumOfScores, double maxScore)
        {
            this.viewer = viewer;
            this.sumOfScores = (float)sumOfScores;
            this.maxScore = (float)maxScore;
        }

        public void AddView(float randomScore)
        {

            this.sumOfScores += randomScore;
            this.scores[viewer] = randomScore;
            viewer++;
        }

        public float GetMaxScore()
        {

            this.maxScore = scores[0];
            for (i = 1; i < viewer; i++)
            {
                if (scores[i] > maxScore) maxScore = scores[i];
            }
            return maxScore;
        }

        public float GetAverageScore()
        {

            return sumOfScores / viewer;
        }

        public int GetViewerCount()
        {
            return viewer;
        }
    }
}
