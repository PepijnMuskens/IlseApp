<script>
export default{
  methods:{
      
    },
    data(){
        return{
            round:{
                name:'',
                number: 0,
                score: 0,
                songs:[
                    ''
                ]
            }
        }
    }
  }

</script>

<template>
  <main class="main-div">
      <button class="btn" @click="StartQuiz()">Start Quiz</button>
  </main>
</template>

<style scoped>
  .btn{
    width: 200pt;
    height: 80pt;
    text-align: center;
    background-color: pink;
  }

  .main-div{
    display: flex;
    flex-direction: column;
    align-items: center;
    width: 100%;
    padding-left: 10%;
    padding-right: 10%;
    padding-top: 20pt;
  }
</style>
