
namespace OOP_krestikiNoliki
{
    class Cell
    {
        private char cellSign;

        public Cell()
        {
            cellSign = '_';
        }

        public char GetSign()
        {
            return cellSign;
        }

        public bool IsEmpty()
        {
            return cellSign == '_';
        }
        public void Set(char sign)
        {
            cellSign = sign;
        }
    }
}
