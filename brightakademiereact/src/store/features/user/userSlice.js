import { createSlice } from "@reduxjs/toolkit";


export const userSlice = createSlice({
    name: 'user',
    initialState: {
        user: false
    },
    reducers: {
        login: (state, action) => {
            state.user = true
            localStorage.setItem('token', action.payload)
        },
        logout: (state) => {
            state.user = false
            localStorage.removeItem('token')
        },
        handleUser: (state) => {
            state.user = !state.user
        }

    }

})

export const { login, logout, handleUser } = userSlice.actions
export default userSlice.reducer