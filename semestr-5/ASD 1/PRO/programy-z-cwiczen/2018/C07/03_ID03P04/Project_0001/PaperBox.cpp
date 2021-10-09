///****************************************************************
PaperBox::PaperBox(double width, double height, double length,
                   double specificWeight):
                   width(width), height(height), length(length),
                   specificWeight(specificWeight){
    SetWeight();
    }
///****************************************************************
double PaperBox::Capacity(){
    return width*height*length;
    }
///****************************************************************
void   PaperBox::SetCapacity(){
    capacity = Capacity();
    }
///****************************************************************
double PaperBox::Weight(){
    SetCapacity();
    return specificWeight * capacity;
    }
///****************************************************************
void   PaperBox::SetWeight(){
    weight = Weight();
    }
///****************************************************************
ostream& operator<<(ostream& s, PaperBox& paperBox){
    paperBox.SetWeight();
    s<<"(wi="<<paperBox.width<<",h="<<paperBox.height<<",l=";
    s<<paperBox.length<<",we="<<paperBox.weight<<",c=";
    s<<paperBox.capacity<<",sW="<<paperBox.specificWeight<<")";
    return s;
    }
///****************************************************************
