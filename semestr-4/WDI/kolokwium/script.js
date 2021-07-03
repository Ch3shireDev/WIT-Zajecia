function changeColor() {
  let color = document.getElementById("select-color").value;
  console.log(color);
  document.getElementById("srodek").style.backgroundColor = color;
}

changeColor();

function addColor() {
  let color = document.getElementById("add-color").value;
  const regex = new RegExp("#([0-9AaBbCcDdEeFf]{6}|[0-9AaBbCcDdEeFf]{3})");
  if (regex.test(color)) {
    var opt = document.createElement("option");
    opt.value = color;
    opt.text = color;
    document.getElementById("select-color").add(opt);
    document.getElementById("select-color").value = color;
    changeColor();
  } else {
    alert("Niepoprawna wartość!");
  }
}

let fontSize = 13;

function changeFont() {
  document.getElementById("font-size").innerHTML = `${fontSize} px`;
  document.documentElement.style = `font-size: ${fontSize}px`;
}

function increaseFont() {
  fontSize++;
  changeFont();
}

function decreaseFont() {
  if (fontSize < 5) return;
  fontSize--;
  changeFont();
}

function setImage() {
  let url = document.getElementById("image-url").value;
  if(url.trim() === ""){
  document.getElementById("image").setAttribute("src", "zdjecie.jpg");
  }
  else{
    document.getElementById("image").setAttribute("src", url);
  }
}
