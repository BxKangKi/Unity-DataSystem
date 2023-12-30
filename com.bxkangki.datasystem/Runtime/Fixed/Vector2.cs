namespace Fixed {
    [System.Serializable]
    public struct Vector2 {
        public Real x;
        public Real y;

        public Vector2(float x = 0f, float y = 0f, int acc = Constants.DefaultAccurancy) {
            this.x = new Real(x, acc);
            this.y = new Real(y, acc);
        }

        public Vector2(UnityEngine.Vector2 value, int acc = Constants.DefaultAccurancy) {
            this.x = new Real(value.x, acc);
            this.y = new Real(value.y, acc);
        }

        public UnityEngine.Vector2 Recover() {
            return new UnityEngine.Vector2(this.x.Recover(), this.y.Recover());
        }
    }
}