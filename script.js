function toggleForm() {
    var form1 = document.getElementById("form1");
    var form2 = document.getElementById("form2");
    var checkbox = document.querySelector(".toggle-switch input");

    if (checkbox.checked) {
      form1.style.display = "flex";
      form2.style.display = "none";
    } else {
      form1.style.display = "none";
      form2.style.display = "flex";
    }
  }