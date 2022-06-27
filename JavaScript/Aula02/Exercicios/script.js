function Calculadora(){
    this .display = document.querySelector( '.display' );
    this .capturaCliques = () => {
    document.addEventListener( 'click' , event => {
    const elemento = event.target;
    if (elemento.classList.contains( 'btn-num' )) this .addNum(elemento);
    if (elemento.classList.contains( 'btn-clear' )) this .clear();
    if (elemento.classList.contains( 'btn-del' )) this .del();
    if (elemento.classList.contains( 'btn-eq' )) this .equal();
        });
    };

    this .capturaEnter = () => {
        document.addEventListener( 'keypress' , btn => {
            if (btn.keyCode === 13) this .equal();
        });
    };

    this .addNum = elemento => {
        this .display.value += elemento.innerText;
        this .display.focus();
    };

    this .clear = () => this .display.value = "" ;

    this .del = () => this .display.value = this .display.value.slice(0, -1);

    this .equal = () => {
        try {
            const conta = eval( this .display.value);
            this .display.value = conta;
        } 
        catch (e){
            alert( "Conta inválida" );
            return ;
        }
    };
    this .inicia = () => {
        this .capturaCliques();
        this .capturaEnter();
    };
}
const calculadora = new Calculadora();
calculadora.inicia();