namespace Fixed
{
    [System.Serializable]
    public struct Color
    {
        public Real r;
        public Real g;
        public Real b;
        public Real a;

        public Color(float r = 0f, float g = 0f, float b = 0f, float a = 0f, int acc = Constants.DefaultAccurancy)
        {
            this.r = new Real(r, acc);
            this.g = new Real(g, acc);
            this.b = new Real(b, acc);
            this.a = new Real(a, acc);

        }

        public Color(UnityEngine.Color value, int acc = Constants.DefaultAccurancy)
        {
            this.r = new Real(value.r, acc);
            this.g = new Real(value.g, acc);
            this.b = new Real(value.b, acc);
            this.a = new Real(value.a, acc);
        }

        public UnityEngine.Color Recover()
        {
            return new UnityEngine.Color(this.r.Recover(), this.g.Recover(), this.b.Recover(), this.a.Recover());
        }
    }
}