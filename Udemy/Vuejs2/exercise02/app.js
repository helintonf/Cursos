new Vue({
        el: '#exercise',
        data: {
            value: ''
        },
        methods:{
        	alertMe:function(){
        		alert('Alerta!');
        	},
        	save:function(event){
        		this.value = event.target.value;
        	}
        }
    });