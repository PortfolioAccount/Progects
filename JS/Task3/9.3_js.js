"use strict";

function getSelectValues(select) {
  var result = [];
  var options = select && select.options;
  var opt;
  for (var i=0, iLen=options.length; i<iLen; i++) {
    opt = options[i];
    if (opt.selected) {
      result.push(opt);
    }
  }
  return result;
}

const oneSelect = document.getElementById("oneSelect");
const twoSelect = document.getElementById("twoSelect");

document.getElementById("rightAll").addEventListener("click", function(){
    let option = oneSelect.options;
    let optionLenght = option.length;
    for (let i = 0; i < optionLenght; i++) {
        twoSelect.appendChild(option[0]);
    }
});

document.getElementById("right").addEventListener("click", function(){
  let checkedOption = getSelectValues(oneSelect);
  checkedOption.forEach(function(item) {
    oneSelect.removeChild(item);
    twoSelect.appendChild(item);
  });
});

document.getElementById("left").addEventListener("click", function(){
    let checkedOption = getSelectValues(twoSelect);
    checkedOption.forEach(function(item) {
        twoSelect.removeChild(item);
        oneSelect.appendChild(item);
    });
});

document.getElementById("leftAll").addEventListener("click", function(){
    let option = twoSelect.options;
    let optionLenght = option.length;
    for (let i = 0; i < optionLenght; i++) {
        oneSelect.appendChild(option[0]);
    }
});