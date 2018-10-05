using System.Collections;

namespace DPWorkout.Structural.Flyweight
{
    public class CategoryFactory
    {
        private Hashtable _categories = new Hashtable();

        public CategoryFactory()
        {
            _categories.Add(1, new Category() { Id = 1, Name = "Utilities", Image=null });
            _categories.Add(2, new Category() { Id = 2, Name = "Mobile", Image = null });
            _categories.Add(3, new Category() { Id = 3, Name = "Internet", Image = null });
        }

        public Category GetCategory(int key)
        {
            return ((Category)_categories[key]);
        }
    }
}
