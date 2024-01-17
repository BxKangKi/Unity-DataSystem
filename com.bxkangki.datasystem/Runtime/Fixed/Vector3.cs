namespace Fixed
{
    [System.Serializable]
    public struct Vector3
    {
        public Real x;
        public Real y;
        public Real z;

        public Vector3(float x = 0f, float y = 0f, float z = 0f, int acc = Constants.DefaultAccurancy)
        {
            this.x = new Real(x, acc);
            this.y = new Real(y, acc);
            this.z = new Real(z, acc);
        }

        public Vector3(UnityEngine.Vector3 value, int acc = Constants.DefaultAccurancy)
        {
            this.x = new Real(value.x, acc);
            this.y = new Real(value.y, acc);
            this.z = new Real(value.z, acc);
        }

        public UnityEngine.Vector3 Recover()
        {
            return new UnityEngine.Vector3(this.x.Recover(), this.y.Recover(), this.z.Recover());
        }
    }
}