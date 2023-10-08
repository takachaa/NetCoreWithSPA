<template>
    <div class="container mt-5">
        <h2>Register</h2>
        <form @submit.prevent="register">
            <div class="mb-3">
                <label for="email" class="form-label">Email address</label>
                <input type="email" class="form-control" id="email" v-model="email">
            </div>
            <div class="mb-3">
                <label for="password" class="form-label">Password</label>
                <input type="password" class="form-control" id="password" v-model="password">
            </div>
            <div class="mb-3">
                <label for="confirmPassword" class="form-label">Confirm Password</label>
                <input type="password" class="form-control" id="confirmPassword" v-model="confirmPassword">
            </div>
            <button type="submit" class="btn btn-primary">Register</button>
        </form>
    </div>
</template>

<script>
    import axios from 'axios';
    import settings from '@/settings';
    const { apiEndpoint } = settings;

    export default {
        name: 'Register',
        data() {
            return {
                email: '',
                password: '',
                confirmPassword: ''
            };
        },
        methods: {
             async register() {
                try {
                    const response = await axios.post(`${apiEndpoint}/api/account/register`, {
                        Email: this.email,
                        Password: this.password,
                        ConfirmPassword: this.confirmPassword
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
