window.onload = function() {
    //Propriedades
    document.getElementById('lnE').innerText = 'Math.E - ' + Math.E;
    document.getElementById('ln2').innerText = 'Math.LN2 - ' + Math.LN2;
    document.getElementById('ln10').innerText = 'Math.LN10 - ' + Math.LN10;
    document.getElementById('log2E').innerText = 'Math.LOG2E - ' + Math.LOG2E
    document.getElementById('log10E').innerText = 'Math.LOG10E - ' + Math.LOG10E
    document.getElementById('PI').innerText = 'Math.PI - ' + Math.PI;
    document.getElementById('SQRT1_2').innerText = 'SQRT1_2 - ' + Math.SQRT1_2;
    document.getElementById('SQRT2').innerText = 'SQRT2 - ' + Math.SQRT2;

    //Métodos
    document.getElementById('Randon').innerText = 'Math.random() - ' + Math.random();
    document.getElementById('Pow').innerText = 'Math.pow(2,3) - ' + Math.pow(2, 3);
    document.getElementById('Sen').innerText = 'Math.sin(120) - ' + Math.sin(120);
    document.getElementById('Cos').innerText = 'Math.cos(45) - ' + Math.cos(45);
    document.getElementById('Tan').innerText = 'Math.tan(30) - ' + Math.tan(180);
    document.getElementById('Round').innerText = 'Math.round(19,678) - ' + Math.round(19, 678);
}