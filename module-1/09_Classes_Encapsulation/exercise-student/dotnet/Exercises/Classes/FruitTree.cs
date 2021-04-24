namespace Exercises.Classes
{
    public class FruitTree
    {
        public string TypeOfFruit { get; private set; }     // gets the type of fruit on the tree

        public int PiecesOfFruitLeft { get; private set; }   // gets the number of remaining fruit pieces on tree

        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            this.PiecesOfFruitLeft = startingPiecesOfFruit;
            this.TypeOfFruit = typeOfFruit;

        }
      

        public bool PickFruit(int NumberOfPiecesToRemove)
        {
            if (NumberOfPiecesToRemove <= this.PiecesOfFruitLeft)
            {
                this.PiecesOfFruitLeft = this.PiecesOfFruitLeft - NumberOfPiecesToRemove;
                return true;
            }
            else 
            {
                return false;
            }
           

            
        }

    }
}
