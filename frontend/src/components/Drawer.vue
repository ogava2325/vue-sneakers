<script setup>
import DrawerHead from '@/components/DrawerHead.vue'
import CartListItem from '@/components/CartListItem.vue'
import { computed } from 'vue'
import InfoBlock from '@/components/InfoBlock.vue'
import { isTSTypeLiteralOrTSFunctionType } from 'eslint-plugin-vue/lib/utils/ts-utils/ts-ast.js'

const emit = defineEmits(['createOrder'])
const props = defineProps({
  totalPrice: Number,
  vatPrice: Number,
  isCreatingOrder: Boolean
})

const buttonDisabled = computed(() => (props.isCreatingOrder ? true : !props.totalPrice))
</script>
<template>
  <div class="fixed top-0 left-0 h-full w-full bg-black z-10 opacity-50"></div>
  <div class="bg-white w-96 h-full fixed right-0 top-0 z-20 p-8">
    <DrawerHead />
    <div v-if="!totalPrice" class="flex h-full items-center">
      <InfoBlock
        title="Cart is empty"
        description="Add at least one pair of sneakers, to make an order"
        image-url="/package-icon.png"
      />
    </div>
    <CartListItem />

    <div v-if="totalPrice" class="flex flex-col gap-4 mt-7">
      <div class="flex gap-2">
        <span>Total:</span>
        <div class="flex-1 border-b border-dashed"></div>
        <b>{{ totalPrice }}$</b>
      </div>

      <div class="flex gap-2">
        <span>Tax 5%:</span>
        <div class="flex-1 border-b border-dashed"></div>
        <b>{{ vatPrice }}$</b>
      </div>
      <button
        @click="() => emit('createOrder')"
        :disabled="buttonDisabled"
        class="transition mt-4 bg-lime-500 w-full rounded-xl py-3 text-white disabled:bg-slate-400 hover:bg-lime-600 active:bg-lime-700 cursor-pointer"
      >
        Place order
      </button>
    </div>
  </div>
</template>
