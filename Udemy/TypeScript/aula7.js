'use strict';
const ct = 4;
let aa = 1;
function funcao2() {
    console.log(aa);
    let bb = 2;
    if (true) {
        let c = 3;
        console.log(bb);
    }
    console.log(c);
    ct =3;
}

funcao2();
