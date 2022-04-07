function Sucesso(data){
    Swal.fire(
        'Sucesso',
        data.msg,
        'success'
      );
}

function Falha(data){
    Swal.fire(
        'Falha',
        'Acesso Negado',
        'error'
      );
}