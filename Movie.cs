using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox02
{
        abstract class Movie
        {
            private string title;
            private string directors;

            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            public string Directors
            {
                get { return directors; }
                set { directors = value; }
            }
            public Movie(string title, string directors)
            {
                this.title = title;
                this.directors = directors;
            }

            public abstract decimal DisplayPrice();

            public override string ToString()
            {
                string str;
                str = string.Format($"Movie Title: {Title}\nDirectors: {Directors}");
                return str;
            }
        }
}

