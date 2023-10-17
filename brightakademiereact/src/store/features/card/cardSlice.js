import { createSlice } from "@reduxjs/toolkit";


const initialState = {
    number: 0,
    products: []
}

export const cardSlice = createSlice({
    name: 'card',
    initialState,
    reducers: {
        increment: (state) => {
            state.number += 1
        },
        decrement: (state) => {
            state.number -= 1
        },
        addProduct: (state, actions) => {
            state.number += 1
            //state.products.push(actions.payload)
            let myIndex = -1
            state.products.map((item, index) => {
                //console.log(index)
                if (item.id === actions.payload.id) {
                    myIndex = index
                }
            })
            if (myIndex === -1) {
                state.products.push(actions.payload)
            } else {
                if (state.products[myIndex]['quantity']) {
                    state.products[myIndex]['quantity'] += 1
                } else {
                    state.products[myIndex]['quantity'] = 2
                }
            }


        },
        clearCard: (state) => {
            state.number = 0
            state.products = []
        }
    }
})

export const { increment, decrement, addProduct, clearCard } = cardSlice.actions

export default cardSlice.reducer