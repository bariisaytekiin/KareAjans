namespace Kareajans.Common
{
    public class Cart
    {
        //Organizasyona daha önceeklenmek istenen manken eklenmiş mi onun kontrolü yapılıyor.

        public  Dictionary<int, CartItem> _myCart = new Dictionary<int, CartItem>();


        public string AddItem(CartItem cartItem)
        {
            if (_myCart.ContainsKey(cartItem.Id))
            {
                
                return"Manken önceden eklendi!";
            }
            _myCart.Add(cartItem.Id, cartItem);
            return "Manken Eklendi.";
        }




    }
}
