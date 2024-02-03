using System;
namespace lab4
{
	public class ClothingSorter
	{

		private readonly List<Clothing> _clothes;


        public ClothingSorter(List<Clothing> clothes)
		{
			_clothes = clothes;
		}

        public void SortByTypeAscending()
        {
            PerformBubbleSort(true);
        }

        public void SortByQuantityDescending()
        {
            PerformBubbleSort(false);
        }


        private void PerformBubbleSort(bool isTypeField)
        {
            for (int i = 0; i < _clothes.Count - 1; i++)
            {
                var swapHappened = false;
                for (int j = 0; j < _clothes.Count - i - 1; j++)
                {
                    if (SwapNeeded(j, isTypeField))
                    {
                        var temp = _clothes[j];
                        _clothes[j] = _clothes[j + 1];
                        _clothes[j + 1] = temp;
                        swapHappened = true;
                    }
                }
                if (!swapHappened) break;
            }

        }


        private bool SwapNeeded(int idx, bool isTypeField)
        {
            if (isTypeField)
            {
                return string.Compare(_clothes[idx].Type, _clothes[idx + 1].Type) > 0;
            }
            return _clothes[idx].Quantity < _clothes[idx + 1].Quantity;
        }
    }
}

