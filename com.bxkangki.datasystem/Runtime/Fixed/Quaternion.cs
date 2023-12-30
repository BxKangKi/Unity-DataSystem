namespace DatsSystem.Fixed {
    [System.Serializable]
    public struct Quaternion {
        public Real x;
        public Real y;
        public Real z;
        public Real w;

        public Quaternion(float x = 0f, float y = 0f, float z = 0f, float w = 0f, int acc = Constants.DefaultAccurancy) {
            this.x = new Real(x, acc);
            this.y = new Real(y, acc);
            this.z = new Real(z, acc);
            this.w = new Real(w, acc);
        }

        public Quaternion(UnityEngine.Quaternion value, int acc = Constants.DefaultAccurancy) {
            this.x = new Real(value.x, acc);
            this.y = new Real(value.y, acc);
            this.z = new Real(value.z, acc);
            this.w = new Real(value.w, acc);
        }

        public UnityEngine.Quaternion Recover() {
            return new UnityEngine.Quaternion(this.x.Recover(), this.y.Recover(), this.z.Recover(), this.w.Recover());
        }
    }
}