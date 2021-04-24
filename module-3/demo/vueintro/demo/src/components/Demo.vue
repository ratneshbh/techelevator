<template>
  <div>
      demo component
      <p>
          {{ message }}
      </p>
      <span v-for="n in number" v-bind:key="n">
            {{n}}
      </span>
        <p>
            Sum of numbers {{arraySum}}
        </p>

        <input type="checkbox" name="checkbox" id="checkbox" v-model="checked">
        <label for="checkbox">click it:</label>
        <p v-bind:class="{hide: checked}">
            Show or hide based on checkbox
        </p>

  </div>
</template>

<script>
export default {

    //component name
    name: "demo",
    //component scoped data
    data: function(){
        return{
            checked: true,
            message: "hello from demo",
            number: [1,2,3,5,8,13]

        }
    },
    computed: {
//must use this
        arraySum () {
            return this.number.reduce(
                (acc,numb)=>{
                    return acc + numb;
                }
            )
        }
    }
}

</script>

<style scoped>
 .hide {
     display: none;
 }
</style>>
