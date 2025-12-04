namespace CategoryClassLibrary;

public struct Category
{
    private int _categoryId;
    private string _categoryName;

    public int CategoryId {
        set {

            if (value >= 1 && value <=40) {
                _categoryId = value;
            }
        }
        get { 
            return _categoryId;
        }
    }

    public string CategoryName {

        set {
                _categoryName = value;  
        }

        get { 
            return _categoryName; 
        }
    }
    public int getNameLength() {
        return _categoryName.Length;
    }
}
