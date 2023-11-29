function RomanoAEntero(Romano){

    const TablaRomanos ={
        M: 1000,
        CM: 900,
        D: 500,
        CD: 400,
        C: 100,
        XC: 90,
        L: 50,
        XL: 40,
        X: 10,
        IX: 9,
        V: 5,
        IV: 4,
        I: 1
    };

    let Resultado = 0;

    for(let i = 0; i < Romano.length; i++){

        if(i === Romano.length - 1 || TablaRomanos[Romano[i+1]] <= TablaRomanos[Romano[i]]){
            Resultado += TablaRomanos[Romano[i]];
        }
        else{
            Resultado -= TablaRomanos[Romano[i]];
        }

    }

    return Resultado;
}

console.log(RomanoAEntero("LVIII"));