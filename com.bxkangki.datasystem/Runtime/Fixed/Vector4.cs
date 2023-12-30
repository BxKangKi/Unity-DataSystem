namespace DatsSystem.Fixed {
    [System.Serializable]
    public struct Vector4 {
        public Real x;
        public Real y;
        public Real z;
        public Real w;

        public Vector4(float x = 0f, float y = 0f, float z = 0f, float w = 0f, int acc = Constants.DefaultAccurancy) {
            this.x = new Real(x, acc);
            this.y = new Real(y, acc);
            this.z = new Real(z, acc);
            this.w = new Real(w, acc);
        }

        public Vector4(UnityEngine.Vector4 value, int acc = Constants.DefaultAccurancy) {
            this.x = new Real(value.x, acc);
            this.y = new Real(value.y, acc);
            this.z = new Real(value.z, acc);
            this.w = new Real(value.w, acc);
        }

        public UnityEngine.Vector4 Recover() {
            return new UnityEngine.Vector4(this.x.Recover(), this.y.Recover(), this.z.Recover(), this.w.Recover());
        }
    }
}