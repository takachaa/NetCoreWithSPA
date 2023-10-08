<template>
    <div>
        <h2>Weather Data</h2>
        <table v-if="weatherData && weatherData.length">
            <thead>
                <tr>
                    <th>Date</th>
                    <th>Temperature (°C)</th>
                    <th>Summary</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="data in weatherData" :key="data.date">
                    <td>{{ data.date }}</td>
                    <td>{{ data.temperatureC }}</td>
                    <td>{{ data.summary }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import axios from 'axios';
    import settings from '@/settings';
    const { apiEndpoint } = settings;

    export default {
        name: 'Weather',
        data() {
            return {
                weatherData: [],
            };
        },
        async created() {
            try {
                const response = await axios.get(`${apiEndpoint}/api/weatherforecast`, {
                    withCredentials: true // クッキー認証のため
                });

                if (response.status === 200) {
                    this.weatherData = response.data;
                } else {
                    console.error('Error occurred:', response.data);
                }
            } catch (error) {
                console.error('API call failed:', error);
            }
        },
    };
</script>

<style>
    /* 必要に応じてスタイルを追加 */
</style>