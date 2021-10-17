///*******************************************************************************************
PaperBox::PaperBox(double width, double height, double length, double specificWeight):
                   width(width), height(height), length(length), specificWeight(specificWeight){
    SetCapacity();
    SetWeight();
    }
///*******************************************************************************************
double PaperBox::WIDTH(){
    SetCapacity();
    SetWeight();
    return width;
    }
///*******************************************************************************************
double PaperBox::HEIGHT(){
    SetCapacity();
    SetWeight();
    return height;
    }
///*******************************************************************************************
double PaperBox::LENGTH(){
    SetCapacity();
    SetWeight();
    return length;
    }
///*******************************************************************************************
double PaperBox::SPECIFICWEIGHT(){
    SetCapacity();
    SetWeight();
    return specificWeight;
    }
///*******************************************************************************************
double PaperBox::CAPACITY(){
    SetCapacity();
    SetWeight();
    return capacity;
    }
///*******************************************************************************************
double PaperBox::WEIGHT(){
    SetCapacity();
    SetWeight();
    return weight;
    }
///*******************************************************************************************
double PaperBox::SetWIDTH(double value){
    SetCapacity();
    SetWeight();
    double tmp = width;
    width = value;
    return tmp;
    }
///*******************************************************************************************
double PaperBox::SetHEIGHT(double value){
    SetCapacity();
    SetWeight();
    double tmp = height;
    height = value;
    return tmp;
    }
///*******************************************************************************************
double PaperBox::SetLENGTH(double value){
    SetCapacity();
    SetWeight();
    double tmp = length;
    length = value;
    return tmp;
    }
///*******************************************************************************************
double PaperBox::SetSPECIFICWEIGHT(double value){
    SetCapacity();
    SetWeight();
    double tmp = specificWeight;
    specificWeight = value;
    return tmp;
    }
///*******************************************************************************************
double PaperBox::Capacity(){
    return width*height*length;
    }
///*******************************************************************************************
void   PaperBox::SetCapacity(){
    capacity = Capacity();
    }
///*******************************************************************************************
double PaperBox::Weight(){
    return specificWeight*Capacity();
    }
///*******************************************************************************************
void   PaperBox::SetWeight(){
    weight = Weight();
    }
///*******************************************************************************************
ostream& operator<<(ostream& s, PaperBox& paperBox){
    paperBox.SetCapacity();
    paperBox.SetWeight();

    s<<"(wi="<<paperBox.width<<",h="<<paperBox.height<<",l="<<paperBox.length<<"we=";
    s<<paperBox.weight<<",c="<<paperBox.capacity<<",sw="<<paperBox.specificWeight<<")";

    return s;
    }
///*******************************************************************************************
