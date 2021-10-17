///***********************************************************************
PaperBox::PaperBox(double width, double height,
                   double  length, double specificWeigth):
                   width(width), height(height), length(length),
                   specificWeigth(specificWeigth){
                   SetCapacity();
                   SetWeigth();
                   }
///***********************************************************************
double PaperBox::Capacity(){
    return width*height*length;
    }
///***********************************************************************
void PaperBox::SetCapacity(){
    capacity = Capacity();
    }
///***********************************************************************
double PaperBox::Weigth(){
    return Capacity()*specificWeigth;
    }
///***********************************************************************
void PaperBox::SetWeigth(){
    weigth = Weigth();
    }
///***********************************************************************
///***********************************************************************
ostream& operator<<(ostream& s, PaperBox& paperBox){
    paperBox.SetCapacity();
    paperBox.SetWeigth();
    s<<"(w="<<paperBox.width<<",h="<<paperBox.height<<",l=";
    s<<paperBox.length<<",C="<<paperBox.capacity<<",sW=";
    s<<paperBox.specificWeigth<<",w="<<paperBox.weigth<<")";
    return s;
    }
///***********************************************************************
