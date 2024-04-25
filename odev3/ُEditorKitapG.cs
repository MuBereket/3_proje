namespace odev3
{
    public enum EditorIncEnum { Reddedildi, Duzenlenecek, Onaylandi }
    public class EditorKitapG
    {
        private Editor editor;
        private string aciklama;
        private EditorIncEnum karar;
        public EditorKitapG(Editor editor, string aciklama, EditorIncEnum karar)
        {
            this.editor = editor;
            this.aciklama = aciklama;
            this.karar = karar;

        }
        public Editor Editor { get { return editor; } }
        public string Aciklama { get { return aciklama; } }
        public EditorIncEnum Karar { get { return karar; } }


    }
}
