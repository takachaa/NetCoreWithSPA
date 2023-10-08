<template>
    <div class="container mt-5">
        <h2>Login</h2>
        <form @submit.prevent="login">
            <div class="mb-3">
                <label for="email" class="form-label">Email address</label>
                <input type="email" class="form-control" id="email" v-model="email">
            </div>
            <div class="mb-3">
                <label for="password" class="form-label">Password</label>
                <input type="password" class="form-control" id="password" v-model="password">
            </div>
            <button type="submit" class="btn btn-primary">Login</button>
        </form>
    </div>
</template>

<script>
    import axios from 'axios';
    import settings from '@/settings';
    const { apiEndpoint } = settings;

    export default {
        name: 'Login',
        data() {
            return {
                email: '',
                password: ''
            };
        },
        methods: {
              async login() {
                 try {
                     const response = await axios.post(`${apiEndpoint}/api/account/login`, {
                         Email: this.email,
                         Password: this.password
                     },{
                         withCredentials: true
                    });

                     if (response.status === 200) {
                         // 登録成功時の処理（例：ルーティング変更、メッセージ表示など）
                         console.log('Registration Successful');
                     } else {
                         // エラーメッセージを表示または他のエラー処理を行う
                         console.error('Error occurred:', response.data);
                     }
                 } catch (error) {
                     // APIリクエストに失敗した場合のエラー処理
                     console.error('API call failed:', error);
                 }
             }
        }
    };
</script>
