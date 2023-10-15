
export default function Login() {
    return (
        <section className="text-gray-600 body-font relative">
            <div className="container px-5 py-24 mx-auto flex justify-center"> {/* "justify-center" ile içeriği ortalarız */}
                <div className="lg:w-1/2 md:w-1/2 bg-white rounded-lg p-8 flex flex-col w-full mt-10 md:mt-0 relative z-10 shadow-md">
                    <h2 className="text-gray-900 text-lg mb-1 font-medium title-font">Kullanıcı Girişi</h2>
                    <div className="relative mb-4">
                        <label for="email" className="leading-7 text-sm text-gray-600">Kullanıcı Adı</label>
                        <input type="text" id="kullanıcıadı" name="kullanıcıadı" className="w-full bg-white rounded border border-gray-300 focus:border-indigo-500 focus:ring-2 focus:ring-indigo-200 text-base outline-none text-gray-700 py-1 px-3 leading-8 transition-colors duration-200 ease-in-out" />
                    </div>
                    <div className="relative mb-4">
                        <label htmlFor="password" className="leading-7 text-sm text-gray-600">Şifreniz</label>
                        <input
                            type="password" // "password" tipi kullanıyoruz
                            id="password"
                            name="password"
                            className="w-full bg-white rounded border border-gray-300 focus:border-indigo-500 focus:ring-2 focus:ring-indigo-200 text-base outline-none text-gray-700 py-1 px-3 leading-8 transition-colors duration-200 ease-in-out"
                        />
                    </div>

                    <button className="text-white bg-indigo-500 border-0 py-2 px-6 focus:outline-none hover:bg-indigo-600 rounded text-lg">Giriş</button>
                </div>
            </div>
        </section>

    )
}
